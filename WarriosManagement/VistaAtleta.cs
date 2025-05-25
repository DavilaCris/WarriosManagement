using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.IO;
using System.Windows.Forms;
using AccesoDatosWM;
using System.Drawing;
using Modelos;

namespace WarriosManagement
{
    public partial class VistaAtleta : MaterialForm
    {
        private int idAtleta;

        public VistaAtleta(int id)
        {
            idAtleta = id;
            InitializeComponent();
            this.FormClosing += cerrar;

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey900,  // Fondo principal muy oscuro
                Primary.BlueGrey800,  // Fondo de barra de título
                Primary.BlueGrey500,  // Color de controles activos
                Accent.Cyan700,       // Color de acento como el texto que usas
                TextShade.WHITE       // Texto blanco
            );

            categorias();
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.SelectedIndexChanged += CbCategoria_SelectedIndexChanged;

            CargarDatosAtleta();
           
        }

        private void CargarDatosAtleta()
        {
            var atleta = AtletaRepositorio.ObtenerAtletaPorId(idAtleta);
            if (atleta != null)
            {
                lblNombre.Text = "Nombre:  " + atleta.Nombre;
                lblApellido.Text = "Apellido:  " + atleta.Apellido;
                lblNacionalidad.Text = "Nacionalidad:  " + atleta.Nacionalidad;
                lblPeso.Text = "Peso:   " + atleta.Peso + " kg";
                lblAltura.Text = "Altura:   " + atleta.Altura + " m";
                lblLateralidad.Text = "Lateralidad:   " + atleta.Lateralidad;
                lblPosicionRank.Text = "Posición Ranking:   " + atleta.Posicion.ToString();
                if (atleta.Imagen != null && atleta.Imagen.Length > 0)
                {
                    using (var ms = new MemoryStream(atleta.Imagen))
                    {
                        pictureBoxFoto.Image = Image.FromStream(ms);
                    }
                }

                gridUltimasPeleas.DataSource = HistorialRepositorio.ObtenerHistorialPorAtleta(idAtleta);
                if (gridUltimasPeleas.Columns.Contains("ResultadoFormateado"))
                {
                    gridUltimasPeleas.Columns["ResultadoFormateado"].HeaderText = "Historial de Enfrentamientos";
                }
            }
            else
            {
                MessageBox.Show("No se encontraron datos para este atleta.");
            }
            this.Text = "" + atleta.NombreCompleto+"    "+atleta.NombreCategoria;
        }

        private void cerrar(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void itemVerRanking_Click(object sender, EventArgs e)
        {
            var categorias = CategoriaRepositorio.ObtenerCategorias();

            ComboBox cb = new ComboBox
            {
                DataSource = categorias,
                DisplayMember = "Nombre",
                ValueMember = "IdCategoria",
                DropDownStyle = ComboBoxStyle.DropDownList,
                Width = 250
            };

            Form popup = new Form
            {
                Width = 300,
                Height = 150,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Seleccionar categoría"
            };

            Button btnSeleccionar = new Button
            {
                Text = "Ver Ranking",
                Top = 50,
                Left = 90,
                Width = 100
            };

            cb.Top = 10;
            cb.Left = 20;

            btnSeleccionar.Click += (s, args) =>
            {
                int idSeleccionado = (int)cb.SelectedValue;
                popup.Close();

                var rankingVista = new VistaRankingPorCategoria(idSeleccionado, cb.Text);
                rankingVista.ShowDialog();
            };

            popup.Controls.Add(cb);
            popup.Controls.Add(btnSeleccionar);
            popup.ShowDialog();
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

        private void CbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem is Categoria categoria && categoria.IdCategoria != 0)
            {
                var vistaRanking = new VistaRankingPorCategoria(categoria.IdCategoria, categoria.Nombre);
                vistaRanking.ShowDialog();
                cbCategoria.SelectedIndex = 0;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

            var vista = new VistaEstadisticasAtleta(idAtleta);
            vista.ShowDialog();

        }
    }
}
