using System;
using System.Text;
using System.Windows.Forms;
using AccesoDatosWM;
using MaterialSkin;
using MaterialSkin.Controls;
using BCrypt.Net;
using Modelos.Modelos;
using System.Drawing;

namespace WarriosManagement
{
    public partial class Login : MaterialForm
    {
        private int usuario;
        public Login()
        {

            InitializeComponent();
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

           /* var hash = BCrypt.Net.BCrypt.HashPassword("Visioncris1+");

           var usuario = new Usuario
            {
                Email = "staff@staff.com",
                ContrasenaHash = Encoding.UTF8.GetBytes(hash),
                TipoUsuario = "STAFF",
                IdStaff = 21
            };
            bool resultado = UsuarioRepositorio.CrearUsuarioAdministrativo(usuario);

            if (resultado)
            {
                MessageBox.Show("Usuario creado exitosamente.");
            }
            else
            {
                MessageBox.Show("Hubo un error al crear el usuario.");
            }*/
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            var user = UsuarioRepositorio.ObtenerUsuarioPorEmail(txtEmail.Text.Trim());
           
            if (user == null)
            {
                MessageBox.Show("Correo no encontrado.");
                return;
            }
            
            // Convertir el hash a string
            string hashGuardado = Encoding.UTF8.GetString(user.ContrasenaHash);

            // Verificar la contraseña ingresada
            bool esValida = BCrypt.Net.BCrypt.Verify(txtPassword.Text, hashGuardado);

    
            if (!esValida)
            {
                MessageBox.Show("Contraseña incorrecta.");
                return;
            }

            // Redirigir si es administrador
            if (user.TipoUsuario == "ADMINISTRADOR")
            {
                var vistaAdmin = new AprobacionAltas(usuario =(int)user.IdAdministrativo);
                vistaAdmin.Show();
                this.Hide();
            }
            if (user.TipoUsuario == "ATLETA")
            {
                 var vistaAdmin = new VistaAtleta(usuario = (int)user.IdAtleta);
                 vistaAdmin.Show();
                 this.Hide();
            }
            if (user.TipoUsuario == "ENTRENADOR")
            {
                var vistaAdmin = new VistaEntrenador(usuario = (int)user.IdEntrenador);
                vistaAdmin.Show();
                this.Hide();

            }
                if (user.TipoUsuario == "STAFF")
                {
                     var vistaAdmin = new AltaEnfrentamientos(usuario = (int)user.IdStaff);
                     vistaAdmin.Show();
                     this.Hide();
                }

            
        }


        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registro = new SolicitudAlta(); // o el formulario que corresponda
            registro.Show();
            this.Hide();
        }

        private void cerrar(object sender, FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var rank = new VistaRankingPorCategoria(); // o el formulario que corresponda
            rank.Show();
            this.Hide();
        }
    }
}
