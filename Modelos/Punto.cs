using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Punto
    {

        public int IdEnfrentamiento { get; set; }
        public int IdAtleta { get; set; }
        public string Accion { get; set; }
        public string Extremidad { get; set; }
        public string Lateralidad { get; set; }
        public int CantidadBanderas { get; set; }
    }
}
