using System;
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

            this.Shown += (s, e) => CargarRanking();
            dgvRanking.CellDoubleClick += dgvRanking_CellDoubleClick;

            categorias();
            cbCategoria.SelectedIndexChanged += CbCategoria_SelectedIndexChanged;

            // Configurar placeholder y eventos del buscador
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
            try
            {
                dgvRanking.SuspendLayout();
                dgvRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                var lista = RankingRepositorio.ObtenerRankingPorCategoria(idCategoria);
                dgvRanking.DataSource = lista;

                if (dgvRanking.Columns.Contains("IdAtleta"))
                    dgvRanking.Columns["IdAtleta"].Visible = false;

                dgvRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            finally
            {
                dgvRanking.ResumeLayout();
            }
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
            dgvRanking.DataSource = resultados;
        }

        private void dgvRanking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvRanking.Rows[e.RowIndex].Cells["IdAtleta"].Value != null)
            {
                int idAtleta = Convert.ToInt32(dgvRanking.Rows[e.RowIndex].Cells["IdAtleta"].Value);
                var vistaAtleta = new VistaAtleta(idAtleta);
                vistaAtleta.ShowDialog();
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
