using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AccesoDatosWM;
using Modelos;

namespace WarriosManagement
{
    public partial class EditarEntrenador : MaterialForm
    {
        private Entrenador entrenador;

        public EditarEntrenador(Entrenador entrenador)
        {
            InitializeComponent();
            this.entrenador = entrenador;

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

            CargarDatos();
        }

        private void CargarDatos()
        {
            txtNombre.Text = entrenador.Nombre;
            txtApellido.Text = entrenador.Apellido;
            dtpFechaNacimiento.Value = entrenador.FechaNacimiento ?? DateTime.Today;
            txtNacionalidad.Text = entrenador.Nacionalidad;
            txtCinturon.Text = entrenador.Cinturon;
            txtCiudad.Text = entrenador.Ciudad;
            txtCalle.Text = entrenador.NumeroCalle.ToString();
            txtPostal.Text = entrenador.CodPostal;
            txtEscuela.Text = entrenador.Escuela;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras.");
                return;
            }

            if (!Regex.IsMatch(txtApellido.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El apellido solo debe contener letras.");
                return;
            }

            if (!int.TryParse(txtCalle.Text, out int numeroCalle) || numeroCalle <= 0)
            {
                MessageBox.Show("Número de calle inválido.");
                return;
            }

            entrenador.Nombre = txtNombre.Text.Trim();
            entrenador.Apellido = txtApellido.Text.Trim();
            entrenador.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            entrenador.Nacionalidad = txtNacionalidad.Text.Trim();
            entrenador.Cinturon = txtCinturon.Text.Trim();
            entrenador.Ciudad = txtCiudad.Text.Trim();
            entrenador.NumeroCalle = numeroCalle;
            entrenador.CodPostal = txtPostal.Text.Trim();
            entrenador.Escuela = txtEscuela.Text.Trim();

            if (EntrenadorRepositorio.ModificarEntrenador(entrenador))
            {
                MessageBox.Show("Entrenador actualizado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar el entrenador.");
            }
        }
    }
}
