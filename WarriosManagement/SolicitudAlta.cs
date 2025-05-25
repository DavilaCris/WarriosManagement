using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AccesoDatosWM;
using Modelos;
using MaterialSkin;
using MaterialSkin.Controls;
using BCrypt.Net;

namespace WarriosManagement
{
    public partial class SolicitudAlta : MaterialForm
    {
        private byte[] imagenSeleccionada;

        public SolicitudAlta()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            this.SizeGripStyle = SizeGripStyle.Hide;

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

            CargarCategorias();
            CargarEntrenadores();
        }

        private void btnAlta_click(object sender, EventArgs e)
        {
            if (!ValidarTexto(txtNombre.Text, "Nombre") ||
                !ValidarTexto(txtApellido.Text, "Apellido") ||
                !ValidarDni(txtDNI.Text) ||
                !ValidarContrasena(txtContra1.Text) ||
                !CoincidenContrasenas(txtContra1.Text, txtContra2.Text) ||
                !ValidarTexto(txtNacionalidad.Text, "Nacionalidad") ||
                !ValidarComboBox(cbCategoria, "Categoría", true) ||
                !ValidarComboBox(cbCinturon, "Cinturón", false) ||
                !ValidarComboBox(cbEntrenador, "Entrenador", true) ||
                !ValidarComboBox(cbTipoUsuario, "Tipo de Usuario", false) ||
                !ValidarComboBox(cbLateralidad, "Lateralidad", false) ||
                !ValidarCorreo(txtCorreo.Text) ||
                !ValidarFechaNacimiento(txtFechNac.Value))
            {
                return;
            }

            if (cbCategoria.SelectedValue == null || (int)cbCategoria.SelectedValue == 0)
            {
                MessageBox.Show("Debe seleccionar una categoría válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SolicitudRegistroRepositorio.ExisteCorreo(txtCorreo.Text))
            {
                MessageBox.Show("El correo electrónico ya está registrado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SolicitudRegistroRepositorio.ExisteDni(txtDNI.Text))
            {
                MessageBox.Show("El DNI ya está registrado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (imagenSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una imagen.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarDecimalEnRango(txtPeso.Text, "Peso", 30, 200, out decimal peso) ||
                !ValidarDecimalEnRango(txtAltura.Text, "Altura", 50, 250, out decimal altura))
            {
                return;
            }

            int idCategoria = (int)cbCategoria.SelectedValue;
            int idEntrenador = (int)cbEntrenador.SelectedValue;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtContra1.Text);
            var solicitud = new SolicitudRegistro
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Dni = txtDNI.Text.ToUpper(),
                Email = txtCorreo.Text,
                ContrasenaHash = Encoding.UTF8.GetBytes(hashedPassword),
                FechaNacimiento = txtFechNac.Value,
                Nacionalidad = txtNacionalidad.Text,
                IdCategoria = idCategoria,
                Cinturon = cbCinturon.SelectedItem.ToString(),
                Imagen = imagenSeleccionada,
                IdEntrenador = idEntrenador,
                TipoUsuarioSolicitado = cbTipoUsuario.SelectedItem.ToString(),
                Lateralidad = cbLateralidad.SelectedItem.ToString(),
                Peso = peso,
                Altura = altura
            };

            int filas = SolicitudRegistroRepositorio.AltaSolicitudRegistro(solicitud);

            if (filas > 0)
            {
                MessageBox.Show("Solicitud enviada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Error al guardar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var login = new Login(); // o el formulario que corresponda
            MessageBox.Show("Solicitud enviada con éxito");

          login.Show();
            this.Hide();
        }

        private void CargarCategorias()
        {
            var categorias = CategoriaRepositorio.ObtenerCategorias();
            categorias.Insert(0, new Categoria { IdCategoria = 0, Nombre = "Seleccione una categoría" });

            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "IdCategoria";
            cbCategoria.SelectedIndex = 0;
        }

        private void CargarEntrenadores()
        {
            var entrenadores = EntrenadorRepositorio.ObtenerEntrenadorNombreApellidoEscuela();
            var lista = entrenadores.Select(e => new {
                Id = e.IDEntrenador,
                Descripcion = $"{e.Nombre} {e.Apellido} - {e.Escuela}"
            }).ToList();

            lista.Insert(0, new { Id = 0, Descripcion = "Seleccione un entrenador" });

            cbEntrenador.DataSource = lista;
            cbEntrenador.DisplayMember = "Descripcion";
            cbEntrenador.ValueMember = "Id";
            cbEntrenador.SelectedIndex = 0;
        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Seleccionar imagen";
                dialog.Filter = "Archivos de imagen (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxFoto.Image = new Bitmap(dialog.FileName);
                    pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    imagenSeleccionada = File.ReadAllBytes(dialog.FileName);
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtContra1.Text = "";
            txtContra2.Text = "";
            txtDNI.Text = "";
            txtNacionalidad.Text = "";
            txtPeso.Text = "";
            txtAltura.Text = "";

            cbCinturon.SelectedIndex = 0;
            cbCategoria.SelectedIndex = 0;
            cbEntrenador.SelectedIndex = 0;
            cbTipoUsuario.SelectedIndex = -1;
            cbLateralidad.SelectedIndex = -1;

            txtFechNac.Value = DateTime.Today;

            pictureBoxFoto.Image = null;
            imagenSeleccionada = null;
        }

        private bool ValidarTexto(string texto, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(texto) || !texto.All(char.IsLetter))
            {
                MessageBox.Show($"El campo '{nombreCampo}' debe contener solo letras y no estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarContrasena(string contrasena)
        {
            if (string.IsNullOrWhiteSpace(contrasena) || contrasena.Length < 8 ||
                !contrasena.Any(char.IsDigit) ||
                !contrasena.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, un número y un carácter especial.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool CoincidenContrasenas(string contrasena1, string contrasena2)
        {
            if (contrasena1 != contrasena2)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarComboBox(ComboBox combo, string nombreCampo, bool tieneOpcionInicial)
        {
            if (combo.SelectedIndex < 0 || combo.SelectedItem == null || (tieneOpcionInicial && combo.SelectedIndex == 0))
            {
                MessageBox.Show($"Debe seleccionar una opción válida en '{nombreCampo}'.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarCorreo(string correo)
        {
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (string.IsNullOrWhiteSpace(correo) || !Regex.IsMatch(correo, patron) || correo.Contains(".."))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarDecimalEnRango(string texto, string nombreCampo, decimal min, decimal max, out decimal resultado)
        {
            resultado = 0;
            if (!decimal.TryParse(texto, out resultado))
            {
                MessageBox.Show($"El campo '{nombreCampo}' debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (resultado < min || resultado > max)
            {
                MessageBox.Show($"El campo '{nombreCampo}' debe estar entre {min} y {max}.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarDni(string dni)
        {
            string patron = @"^[A-Z]\d{7}[A-Z]$";
            if (string.IsNullOrWhiteSpace(dni) || !Regex.IsMatch(dni.ToUpper(), patron))
            {
                MessageBox.Show("El DNI debe tener el formato correcto (Ej: Y1234567Z).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarFechaNacimiento(DateTime fecha)
        {
            var hoy = DateTime.Today;
            var edad = hoy.Year - fecha.Year;
            if (fecha > hoy)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser posterior al día de hoy.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (fecha > hoy.AddYears(-edad)) edad--;
            if (edad < 16)
            {
                MessageBox.Show("Debe tener al menos 16 años para registrarse.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
