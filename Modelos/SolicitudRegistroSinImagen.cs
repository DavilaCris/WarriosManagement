using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class SolicitudRegistroSinImagen
    {
        public int IdSolicitud { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Cinturon { get; set; }
        public int IdCategoria { get; set; }
        public int Puntos { get; set; }
        public bool EnRanking { get; set; }
        public int IdEntrenador { get; set; }
        public string Lateralidad { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public bool Aprobado { get; set; }
        public string Email { get; set; }
        public string TipoUsuarioSolicitado { get; set; }
    }
}
