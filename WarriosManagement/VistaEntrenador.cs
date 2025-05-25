using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Linq;
using System.Windows.Forms;
using AccesoDatosWM;
using Modelos;
using System.Drawing;
using System.IO;

namespace WarriosManagement
{
    public partial class VistaEntrenador : MaterialForm
    {
        private int user;

        public VistaEntrenador(int idEntrenador)
        {
            user = idEntrenador;
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
            cbCategoria.SelectedIndexChanged += CbCategoria_SelectedIndexChanged;
            CargarComboAlumnos(user);
        }

        private void cerrar(object sender, FormClosingEventArgs e)
        {
            // Solo cerrar el formulario actual, no la aplicación entera
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
                var vistaRanking = new VistaRankingPorCategoria(categoria.IdCategoria, categoria.Nombre);
                vistaRanking.ShowDialog(); // this mantiene la jerarquía del form
                cbCategoria.SelectedIndex = 0;
            }
        }

        private void CargarComboAlumnos(int idEntrenador)
        {
            var atletas = AtletaRepositorio.ObtenerAtletasPorEntrenador(idEntrenador);

            var atletasAka = atletas
                .Select(a => new {
                    IdAtleta = a.IdAtleta,
                    NombreCompleto = a.Nombre + " " + a.Apellido
                })
                .ToList();

            atletasAka.Insert(0, new { IdAtleta = 0, NombreCompleto = "Mis Alumnos" });

            cbAlumnos.DataSource = atletasAka;
            cbAlumnos.DisplayMember = "NombreCompleto";
            cbAlumnos.ValueMember = "IdAtleta";
            cbAlumnos.DropDownStyle = ComboBoxStyle.DropDownList;

            cbAlumnos.SelectedIndexChanged += (s, e) =>
            {
                if (cbAlumnos.SelectedIndex <= 0) return;

                int idSeleccionado = (int)cbAlumnos.SelectedValue;

                var vista = new VistaEstadisticasAtleta(idSeleccionado);
                vista.ShowDialog(); 

                cbAlumnos.SelectedIndex = 0;
            };
        }
    }
}
