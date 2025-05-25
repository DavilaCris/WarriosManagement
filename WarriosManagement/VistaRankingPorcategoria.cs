using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AccesoDatosWM;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelos;

namespace WarriosManagement
{
    public partial class VistaRankingPorCategoria : MaterialForm
    {
        private int idCategoria;
        private string nombreCategoria;

        public VistaRankingPorCategoria(int idCategoria, string nombreCategoria)
        {

            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;

            InitializeComponent();

            this.Text = $"Ranking - {nombreCategoria}";
            this.FormClosing += cerrar;
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey900,
                Primary.BlueGrey800,
                Primary.BlueGrey500,
                Accent.Cyan700,
                TextShade.WHITE
            );

            this.Load += (s, e) => CargarRanking();
            dgvRanking.CellDoubleClick += dgvRanking_CellDoubleClick;

            categorias();
            cbCategoria.SelectedIndexChanged += CbCategoria_SelectedIndexChanged;

            txtBuscarNombre.Text = "Buscar atleta...";
            txtBuscarNombre.ForeColor = Color.Gray;

            txtBuscarNombre.Enter += (s, e) =>
            {
                if (txtBuscarNombre.Text == "Buscar atleta...")
                {
                    txtBuscarNombre.Text = "";
                    txtBuscarNombre.ForeColor = Color.WhiteSmoke;
                }
            };

            txtBuscarNombre.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscarNombre.Text))
                {
                    txtBuscarNombre.Text = "Buscar atleta...";
                    txtBuscarNombre.ForeColor = Color.Gray;
                }
            };

            txtBuscarNombre.TextChanged += (s, e) => BuscarPorNombreTiempoReal();
        }

        public VistaRankingPorCategoria() : this(1, "Bienvenido!") { }

        private void CargarRanking()
        {
            dgvRanking.Columns.Clear();
            dgvRanking.Rows.Clear();

            // Columnas (incluye IdAtleta oculta)
            dgvRanking.Columns.Add("IdAtleta", "IdAtleta");
            dgvRanking.Columns["IdAtleta"].Visible = false;
            dgvRanking.Columns.Add("Nombre", "Nombre");
            dgvRanking.Columns.Add("Apellido", "Apellido");
            dgvRanking.Columns.Add("DNI", "DNI");
            dgvRanking.Columns.Add("FechaNacimiento", "Fecha de Nacimiento");
            dgvRanking.Columns.Add("Nacionalidad", "Nacionalidad");
            dgvRanking.Columns.Add("Cinturon", "Cinturón");
            dgvRanking.Columns.Add("Puntos", "Puntos");
            dgvRanking.Columns.Add("Lateralidad", "Lateralidad");
            dgvRanking.Columns.Add("Peso", "Peso");
            dgvRanking.Columns.Add("NombreCategoria", "Categoría");
            dgvRanking.Columns.Add("Posicion", "Posición");

            var lista = RankingRepositorio.ObtenerRankingPorCategoria(idCategoria);
            if (lista == null) return;

            foreach (var atleta in lista)
            {
                dgvRanking.Rows.Add(
                    atleta.IdAtleta,
                    atleta.Nombre,
                    atleta.Apellido,
                    atleta.DNI,
                    atleta.FechaNacimiento.ToString("dd/MM/yyyy"),
                    atleta.Nacionalidad,
                    atleta.Cinturon,
                    atleta.Puntos,
                    atleta.Lateralidad,
                    atleta.Peso.ToString("0.0"),
                    atleta.NombreCategoria,
                    atleta.Posicion
                );
            }

            dgvRanking.DefaultCellStyle.ForeColor = Color.White;
            dgvRanking.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvRanking.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRanking.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dgvRanking.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;
            dgvRanking.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRanking.ClearSelection();
            dgvRanking.Refresh();
        }

        private void BuscarPorNombreTiempoReal()
        {
            string textoBusqueda = txtBuscarNombre.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda) || textoBusqueda == "Buscar atleta...")
            {
                CargarRanking();
                return;
            }

            var resultados = RankingRepositorio.BuscarRankingPorNombre(textoBusqueda);
            dgvRanking.Rows.Clear();

            foreach (var atleta in resultados)
            {
                dgvRanking.Rows.Add(
                    atleta.IdAtleta,
                    atleta.Nombre,
                    atleta.Apellido,
                    atleta.DNI,
                    atleta.FechaNacimiento.ToString("dd/MM/yyyy"),
                    atleta.Nacionalidad,
                    atleta.Cinturon,
                    atleta.Puntos,
                    atleta.Lateralidad,
                    atleta.Peso.ToString("0.0"),
                    atleta.NombreCategoria,
                    atleta.Posicion
                );
            }

            dgvRanking.ClearSelection();
        }

        private void dgvRanking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object valor = dgvRanking.Rows[e.RowIndex].Cells["IdAtleta"].Value;
                if (valor != null && int.TryParse(valor.ToString(), out int id))
                {
                    var vista = new VistaAtletaSimple(id);
                    vista.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el Id del atleta.");
                }
            }
        }

        private void cerrar(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
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
                this.idCategoria = categoria.IdCategoria;
                this.nombreCategoria = categoria.Nombre;
                this.Text = $"Ranking - {nombreCategoria}";
                CargarRanking();
            }
        }
    }
}
