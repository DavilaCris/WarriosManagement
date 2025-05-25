using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using AccesoDatosWM;
using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace WarriosManagement
{
    public partial class AltaEnfrentamientos : MaterialForm
    {
        int user;
        int? idTorneoActual;

        public AltaEnfrentamientos(int idUsuario)
        {
            user = idUsuario;
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
            InicializarEstadoInicial();
            InicializarCombos();
            CargarArbitrosYAtletas();
        }

        private void InicializarEstadoInicial()
        {
            DateTime fecha = DateTime.Today;
            this.lblFecha.Text = "" + fecha.ToShortDateString();

            idTorneoActual = RepositorioTorneos.BuscarIdTorneoPorFecha(fecha);

            if (idTorneoActual == null)
            {
                MessageBox.Show("No se encontró un torneo para la fecha actual.");
                return;
            }

            txtTorneo.Text = "ID Torneo " + idTorneoActual.ToString();
            txtStaff.Text = "STAFF " + user.ToString();

            cbAtletaAka.Enabled = true;
            cbAtletaAo.Enabled = true;
            cbArbitroCentral.Enabled = true;
            cbArbitro1.Enabled = true;
            cbArbitro2.Enabled = true;
            cbArbitro3.Enabled = true;
            cbArbitro4.Enabled = true;

            txtGanador.Enabled = false;
            txtTorneo.Enabled = false;
            cbAccion.Enabled = false;
            cbExtremidad.Enabled = false;
            cbLateralidad.Enabled = false;
            cbBanderas.Enabled = false;
            txtStaff.Enabled = false;
            materialButton1.Enabled = false;
            cbAtletaPuntos.Enabled = false;
            txtGanador.ReadOnly = true;
            txtTorneo.ReadOnly = true;

            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbArbitro1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAtletaAka.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAtletaAo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbArbitroCentral.DropDownStyle = ComboBoxStyle.DropDownList;
            cbArbitro2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbArbitro3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbArbitro4.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAtletaPuntos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InicializarCombos()
        {
            cbAccion.Items.Clear();
            cbAccion.Items.Add("Acción");
            cbAccion.Items.AddRange(new object[]
            {
                "IPPON", "WAZAARI", "YUKO", "CHUKOKU", "KEYOKU",
                "HANSOKU_CHUI", "HANSOKU", "SHOKKAKU", "LESION"
            });
            cbAccion.SelectedIndex = 0;

            cbExtremidad.Items.Clear();
            cbExtremidad.Items.Add("Extremidad");
            cbExtremidad.Items.AddRange(new object[] { "MANO", "PIE" });
            cbExtremidad.SelectedIndex = 0;

            cbLateralidad.Items.Clear();
            cbLateralidad.Items.Add("Lateralidad");
            cbLateralidad.Items.AddRange(new object[] { "DERECHA", "IZQUIERDA" });
            cbLateralidad.SelectedIndex = 0;

            cbBanderas.Items.Clear();
            cbBanderas.Items.Add("Banderas");
            cbBanderas.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbBanderas.SelectedIndex = 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTorneoActual == null)
                {
                    MessageBox.Show("No hay torneo válido para hoy.");
                    return;
                }
                int idAka = Convert.ToInt32(cbAtletaAka.SelectedValue);
                int idAo = Convert.ToInt32(cbAtletaAo.SelectedValue);

                // Validación para evitar que los atletas sean iguales
                if (idAka == idAo)
                {
                    MessageBox.Show("No se puede seleccionar el mismo atleta para AKA y AO.");
                    return;
                }
                var enfrentamiento = new Enfrentamiento
                {
                    IdAtletaAka = Convert.ToInt32(cbAtletaAka.SelectedValue),
                    IdAtletaAo = Convert.ToInt32(cbAtletaAo.SelectedValue),
                    IdArbitroCentral = Convert.ToInt32(cbArbitroCentral.SelectedValue),
                    IdArbitro1 = Convert.ToInt32(cbArbitro1.SelectedValue),
                    IdArbitro2 = Convert.ToInt32(cbArbitro2.SelectedValue),
                    IdArbitro3 = Convert.ToInt32(cbArbitro3.SelectedValue),
                    IdArbitro4 = Convert.ToInt32(cbArbitro4.SelectedValue),
                    IdStaff = user,
                    IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue),
                    IdTorneo = idTorneoActual.Value,
                    IdGanador = null
                };

                EnfrentamientoRepositorio.GuardarEnfrentamiento(enfrentamiento);

                MessageBox.Show("Enfrentamiento guardado correctamente.");

                cbAtletaAka.Enabled = false;
                cbAtletaAo.Enabled = false;
                cbArbitroCentral.Enabled = false;
                cbArbitro1.Enabled = false;
                cbArbitro2.Enabled = false;
                cbArbitro3.Enabled = false;
                cbArbitro4.Enabled = false;
                cbCategoria.Enabled = false;

                cbAccion.Enabled = true;
                cbExtremidad.Enabled = true;
                cbLateralidad.Enabled = true;
                cbBanderas.Enabled = true;
                txtGanador.Enabled = false;
                cbAtletaPuntos.Enabled = true;

                materialButton1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar enfrentamiento: " + ex.Message);
            }
            var atletasDelEnfrentamiento = new List<Atleta>
{
                  new Atleta { IdAtleta = 0, Nombre = "Seleccione Atleta" },
    new Atleta { IdAtleta = Convert.ToInt32(cbAtletaAka.SelectedValue), Nombre = cbAtletaAka.Text },
    new Atleta { IdAtleta = Convert.ToInt32(cbAtletaAo.SelectedValue), Nombre = cbAtletaAo.Text }
};
           
           
            cbAtletaPuntos.DataSource = atletasDelEnfrentamiento;
            cbAtletaPuntos.DisplayMember = "Nombre";
            cbAtletaPuntos.ValueMember = "IdAtleta";
            cbAtletaPuntos.SelectedIndex = 0;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección
                if (cbAtletaPuntos.SelectedIndex == 0 ||
                    cbAccion.SelectedIndex == 0 ||
                    cbExtremidad.SelectedIndex == 0 ||
                    cbLateralidad.SelectedIndex == 0 ||
                    cbBanderas.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar todos los campos correctamente para registrar el punto.");
                    return;
                }

                // Obtener el ID del enfrentamiento actual
                int idEnfrentamiento = PuntosRepositorio.ObtenerUltimoEnfrentamiento();
              
                // Parsear el valor de banderas de forma segura
                bool parseOk = int.TryParse(cbBanderas.SelectedItem.ToString(), out int cantidadBanderas);
                if (!parseOk)
                {
                    MessageBox.Show("La cantidad de banderas seleccionada no es válida.");
                    return;
                }

                // Crear objeto Puntos
                var punto = new Punto
                {
                    IdEnfrentamiento = idEnfrentamiento,
                    IdAtleta = Convert.ToInt32(cbAtletaPuntos.SelectedValue),
                    Accion = cbAccion.SelectedItem.ToString(),
                    Extremidad = cbExtremidad.SelectedItem.ToString(),
                    Lateralidad = cbLateralidad.SelectedItem.ToString(),
                    CantidadBanderas = cantidadBanderas
                };

                // Guardar en BD
                bool exito = PuntosRepositorio.GuardarPunto(punto);
                string ganador = EnfrentamientoRepositorio.ObtenerNombreGanadorActual(idEnfrentamiento);
                txtMarcador.Text = EnfrentamientoRepositorio.ObtenerMarcadorDesdeVista(idEnfrentamiento);

                if (!string.IsNullOrEmpty(ganador))
                {
                    txtGanador.Text = ganador;
                }
                else
                {
                    txtGanador.Text = "Sin definir";
                }

                if (exito)
                {
                    MessageBox.Show("Punto registrado correctamente.");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el punto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar punto: " + ex.Message);

            }
            InicializarCombos();
          
        }




        private void CargarArbitrosYAtletas()
        {
            // Categorías
            var categorias = CategoriaRepositorio.ObtenerCategorias();
            categorias.Insert(0, new Categoria { IdCategoria = 0, Nombre = "Seleccione una categoría" });

            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "IdCategoria";
            cbCategoria.SelectedIndex = 0;

            // Árbitros
            var arbitros = ArbitroRepositorio.ObtenerArbitros();

            var arbitrosCentral = arbitros
                .Select(a => new {
                    IdArbitro = a.IdArbitro,
                    NombreCompleto = a.Nombre + " " + a.Apellido
                })
                .ToList();
            arbitrosCentral.Insert(0, new { IdArbitro = 0, NombreCompleto = "Seleccione árbitro central" });
            cbArbitroCentral.DataSource = arbitrosCentral;
            cbArbitroCentral.DisplayMember = "NombreCompleto";
            cbArbitroCentral.ValueMember = "IdArbitro";

            var arbitros1 = arbitros
                .Select(a => new {
                    IdArbitro = a.IdArbitro,
                    NombreCompleto = a.Nombre + " " + a.Apellido
                })
                .ToList();
            arbitros1.Insert(0, new { IdArbitro = 0, NombreCompleto = "Seleccione árbitro 1" });
            cbArbitro1.DataSource = arbitros1;
            cbArbitro1.DisplayMember = "NombreCompleto";
            cbArbitro1.ValueMember = "IdArbitro";

            var arbitros2 = arbitros
                .Select(a => new {
                    IdArbitro = a.IdArbitro,
                    NombreCompleto = a.Nombre + " " + a.Apellido
                })
                .ToList();
            arbitros2.Insert(0, new { IdArbitro = 0, NombreCompleto = "Seleccione árbitro 2" });
            cbArbitro2.DataSource = arbitros2;
            cbArbitro2.DisplayMember = "NombreCompleto";
            cbArbitro2.ValueMember = "IdArbitro";

            var arbitros3 = arbitros
                .Select(a => new {
                    IdArbitro = a.IdArbitro,
                    NombreCompleto = a.Nombre + " " + a.Apellido
                })
                .ToList();
            arbitros3.Insert(0, new { IdArbitro = 0, NombreCompleto = "Seleccione árbitro 3" });
            cbArbitro3.DataSource = arbitros3;
            cbArbitro3.DisplayMember = "NombreCompleto";
            cbArbitro3.ValueMember = "IdArbitro";

            var arbitros4 = arbitros
                .Select(a => new {
                    IdArbitro = a.IdArbitro,
                    NombreCompleto = a.Nombre + " " + a.Apellido
                })
                .ToList();
            arbitros4.Insert(0, new { IdArbitro = 0, NombreCompleto = "Seleccione árbitro 4" });
            cbArbitro4.DataSource = arbitros4;
            cbArbitro4.DisplayMember = "NombreCompleto";
            cbArbitro4.ValueMember = "IdArbitro";

            // Atletas
            var atletas = AtletaRepositorio.ObtenerAtletas();

            var atletasAka = atletas
                .Select(a => new {
                    IdAtleta = a.IdAtleta,
                    NombreCompleto = a.Nombre + " " + a.Apellido
                })
                .ToList();
            atletasAka.Insert(0, new { IdAtleta = 0, NombreCompleto = "Seleccione atleta AKA" });
            cbAtletaAka.DataSource = atletasAka;
            cbAtletaAka.DisplayMember = "NombreCompleto";
            cbAtletaAka.ValueMember = "IdAtleta";

            var atletasAo = atletas
                .Select(a => new {
                    IdAtleta = a.IdAtleta,
                    NombreCompleto = a.Nombre + " " + a.Apellido
                })
                .ToList();
            atletasAo.Insert(0, new { IdAtleta = 0, NombreCompleto = "Seleccione atleta AO" });
            cbAtletaAo.DataSource = atletasAo;
            cbAtletaAo.DisplayMember = "NombreCompleto";
            cbAtletaAo.ValueMember = "IdAtleta";
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se inicia nuevo enfrentamiento.");
            CargarArbitrosYAtletas();
            InicializarEstadoInicial();
        }
        private void cerrar(object sender, FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }
    }
}
