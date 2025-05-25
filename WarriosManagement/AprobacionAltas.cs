using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AccesoDatosWM;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelos;

namespace WarriosManagement
{
    public partial class AprobacionAltas : MaterialForm
    {
        private int usuario;
        public AprobacionAltas(int usuarioRec)
        {
            usuario = usuarioRec;
            InitializeComponent();
            ConfigurarGrid();
            CargarSolicitudes();
            this.FormClosing += cerrar;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey900,  // Fondo principal muy oscuro
                Primary.BlueGrey800,  // Fondo de barra de título
                Primary.BlueGrey500,  // Color de controles activos
                Accent.Cyan700,       // Color de acento como el texto que usas
                TextShade.WHITE       // Texto blanco
            );

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            categorias();
            cbCategoria.SelectedIndexChanged += CbCategoria_SelectedIndexChanged;
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (gridSolicitudes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una solicitud para aprobar.");
                return;
            }

            int idSolicitud = (int)gridSolicitudes.SelectedRows[0].Cells["IdSolicitud"].Value;

            SolicitudRegistroRepositorio.AprobarSolicitud(idSolicitud);
            MessageBox.Show("Solicitud aprobada correctamente.");

            CargarSolicitudes(); // refrescar la grilla
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (gridSolicitudes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una solicitud para denegar.");
                return;
            }

            var confirm = MessageBox.Show("¿Estás seguro de que deseas eliminar esta solicitud?", "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                int idSolicitud = (int)gridSolicitudes.SelectedRows[0].Cells["IdSolicitud"].Value;

                SolicitudRegistroRepositorio.EliminarSolicitud(idSolicitud);
                MessageBox.Show("Solicitud eliminada.");

                CargarSolicitudes(); // refrescar la grilla
            }
        }

        private void administrarCampeonatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vistaAlataCampeonato = new AltaCampeonato(usuario);
            vistaAlataCampeonato.Show();
            this.Hide();
        }

        private void CargarSolicitudes()
        {
            var solicitudes = SolicitudRegistroRepositorio.ObtenerSolicitudes();
            gridSolicitudes.DataSource = solicitudes;
        }

        private void categorias() {
            var categorias = CategoriaRepositorio.ObtenerCategorias();
            categorias.Insert(0, new Categoria { IdCategoria = 0, Nombre = "Ranking" });

            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "IdCategoria";
            cbCategoria.SelectedIndex = 0;
        }

       
        private void ConfigurarGrid()
        {
            gridSolicitudes.AutoGenerateColumns = true;
            gridSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSolicitudes.MultiSelect = false;
            gridSolicitudes.ReadOnly = true;
            gridSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void campeonatosMenuItem_Click(object sender, EventArgs e)
        {
            var vistaAlataCampeonato = new AltaCampeonato(usuario);
            vistaAlataCampeonato.Show();
            this.Hide();
        }


        private void cerrar(object sender, FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }

        private void entrenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ChatForm = new ListaEntrenadores();
            ChatForm.Show();
        }
        private void CbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem is Categoria categoria && categoria.IdCategoria != 0)
            {
                var vistaRanking = new VistaRankingPorCategoria(categoria.IdCategoria,categoria.Nombre);
                vistaRanking.ShowDialog();
                cbCategoria.SelectedIndex = 0;
            }
        }
    }
}
