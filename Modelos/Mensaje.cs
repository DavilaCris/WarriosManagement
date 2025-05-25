using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Mensaje
    {
        public int IdMensaje { get; set; }
        public int IdEmisor { get; set; }
        public int IdReceptor { get; set; }
        public string Texto { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Leido { get; set; }
    }
}
