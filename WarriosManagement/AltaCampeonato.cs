using System;
using System.Windows.Forms;
using AccesoDatosWM;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelos;

namespace WarriosManagement
{
    public partial class AltaCampeonato : MaterialForm
    {
        private int usuario;

        public AltaCampeonato(int usuarioRec)
        {
            usuario = usuarioRec;
            InitializeComponent();
            CargarTorneos();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCiudad.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona una ciudad.");
                    return;
                }

                var torneo = new Torneo
                {
                    Nombre = txtNombre.Text.Trim(),
                    Ciudad = cbCiudad.SelectedItem.ToString(),
                    Calle = txtCalle.Text.Trim(),
                    NumeroCalle = int.Parse(txtNumeroCalle.Text),
                    CodPostal = txtCodPostal.Text.Trim(),
                    Fecha = datePickerFecha.Value.Date
                };

                RepositorioTorneos.GuardarTorneo(torneo);
                CargarTorneos();
                LimpiarCampos();
                MessageBox.Show("Se ha guardado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el torneo: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listTorneos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un torneo para eliminar.");
                return;
            }

            int id = int.Parse(listTorneos.SelectedItems[0].Text);
            RepositorioTorneos.EliminarTorneo(id);
            CargarTorneos();
            MessageBox.Show("Se ha eliminado correctamente");
        }
        private void categorias()
        {
            var categorias = CategoriaRepositorio.ObtenerCategorias();
            categorias.Insert(0, new Categoria { IdCategoria = 0, Nombre = "Ranking" });

            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "IdCategoria";
            cbCategoria.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            cbCiudad.SelectedIndex = -1;
            txtCalle.Text = "";
            txtNumeroCalle.Text = "";
            txtCodPostal.Text = "";
            datePickerFecha.Value = DateTime.Now;
        }

        private void CargarTorneos()
        {
            listTorneos.Items.Clear();
            var torneos = RepositorioTorneos.ListarTorneos();

            foreach (var torneo in torneos)
            {
                var item = new ListViewItem(torneo.IdTorneo.ToString());
                item.SubItems.Add(torneo.Nombre);
                item.SubItems.Add(torneo.Ciudad);
                item.SubItems.Add(torneo.Calle);
                item.SubItems.Add(torneo.NumeroCalle.ToString());
                item.SubItems.Add(torneo.CodPostal);
                item.SubItems.Add(torneo.Fecha.ToShortDateString());

                listTorneos.Items.Add(item);
            }

            listTorneos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }



        private void entrenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vista = new ListaEntrenadores();
            vista.Show();
        }



        private void atletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vista = new AprobacionAltas(usuario);
            vista.Show();
            this.Hide();
        }

        private void rankingsMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sección de Rankings próximamente...");
        }

        private void cerrar(object sender, FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }

        private void CbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem is Categoria categoria && categoria.IdCategoria != 0)
            {
                var vistaRanking = new VistaRankingPorCategoria(categoria.IdCategoria, categoria.Nombre);
                vistaRanking.ShowDialog();
                cbCategoria.SelectedIndex = 0; // Volver a "Ranking"
            }
        }
    }
}
