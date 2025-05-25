using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Enfrentamiento
    {
        public int IdEnfrentamiento { get; set; }
        public int IdAtletaAka { get; set; }
        public int IdAtletaAo { get; set; }
        public int IdArbitroCentral { get; set; }
        public int IdArbitro1 { get; set; }
        public int IdArbitro2 { get; set; }
        public int IdArbitro3 { get; set; }
        public int IdArbitro4 { get; set; }
        public int IdStaff { get; set; }
        public int? IdGanador { get; set; }
        public int IdTorneo { get; set; }
        public int IdCategoria { get; set; }
        public int Totales { get; set; }
        public int Ganados { get; set; }
        public int Perdidos { get; set; }
    }
}
