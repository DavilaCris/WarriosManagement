using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Torneo
    {
        public int IdTorneo { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Calle { get; set; }
        public int NumeroCalle { get; set; }
        public string CodPostal { get; set; }
        public DateTime Fecha { get; set; }
    }
}