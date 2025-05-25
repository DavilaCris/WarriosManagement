using System;

namespace Modelos
{
    public class RankingAtleta
    {
        public int IdAtleta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Cinturon { get; set; }
        public int Puntos { get; set; }
        public string Lateralidad { get; set; }
        public double Peso { get; set; }
        public string NombreCategoria { get; set; }
        public int Posicion { get; set; }
    }
}
