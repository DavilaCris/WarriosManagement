using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Atleta
    {
        public int IdAtleta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Cinturon { get; set; }
        public string Lateralidad { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public int? IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public int Posicion { get; set; }
        public int? IdEntrenador { get; set; }
        public byte[] Imagen { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";
       
    }
}
