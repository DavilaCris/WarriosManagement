using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Windows.Forms;
using AccesoDatosWM;
using Modelos;

namespace WarriosManagement
{
    public partial class ListaEntrenadores : MaterialForm
    {
        public ListaEntrenadores()
        {
            InitializeComponent();

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

            dgvEntrenadores.AutoGenerateColumns = false;
            CargarEntrenadores();
        }

        private void CargarEntrenadores()
        {
            dgvEntrenadores.Columns.Clear();
            dgvEntrenadores.DataSource = null;

            var entrenadores = EntrenadorRepositorio.ObtenerEntrenadores();
            dgvEntrenadores.DataSource = entrenadores;

            // Agregar columnas si no existen aún
            if (dgvEntrenadores.Columns.Count == 0 || dgvEntrenadores.Columns["Nombre"] == null)
            {
                dgvEntrenadores.Columns.Add("Nombre", "Nombre");
                dgvEntrenadores.Columns["Nombre"].DataPropertyName = "Nombre";

                dgvEntrenadores.Columns.Add("Apellido", "Apellido");
                dgvEntrenadores.Columns["Apellido"].DataPropertyName = "Apellido";

                dgvEntrenadores.Columns.Add("Cinturon", "Cinturón");
                dgvEntrenadores.Columns["Cinturon"].DataPropertyName = "Cinturon";

                dgvEntrenadores.Columns.Add("Escuela", "Escuela");
                dgvEntrenadores.Columns["Escuela"].DataPropertyName = "Escuela";

                // Botón Editar
                var btnEditar = new DataGridViewButtonColumn
                {
                    Name = "Editar",
                    HeaderText = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true
                };
                dgvEntrenadores.Columns.Add(btnEditar);

                // Botón Eliminar
                var btnEliminar = new DataGridViewButtonColumn
                {
                    Name = "Eliminar",
                    HeaderText = "Eliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };
                dgvEntrenadores.Columns.Add(btnEliminar);
            }
        }

        private void dgvEntrenadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var entrenador = (Entrenador)dgvEntrenadores.Rows[e.RowIndex].DataBoundItem;

            if (dgvEntrenadores.Columns[e.ColumnIndex].Name == "Editar")
            {
                var editarForm = new EditarEntrenador(entrenador);
                editarForm.ShowDialog();
                CargarEntrenadores();
            }
            else if (dgvEntrenadores.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                var confirmar = MessageBox.Show("¿Desea eliminar este entrenador?", "Confirmación", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    EntrenadorRepositorio.EliminarEntrenador(entrenador.IDEntrenador);
                    CargarEntrenadores();
                }
            }
        }
    }
}
