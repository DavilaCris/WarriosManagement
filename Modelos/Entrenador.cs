using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Entrenador
    {
        
        public int IDEntrenador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Cinturon { get; set; }
        public string Ciudad { get; set; }
        public int? NumeroCalle { get; set; }
        public string CodPostal { get; set; }
        public string Escuela { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";

    }
}
