using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    namespace Modelos
    {
        public class Usuario
        {
            public int IdUsuario { get; set; }
            public string Email { get; set; }
            public byte[] ContrasenaHash { get; set; }
            public string TipoUsuario { get; set; }
            public int? IdAtleta { get; set; }
            public int? IdArbitro { get; set; }
            public int? IdStaff { get; set; }
            public int? IdEntrenador { get; set; }
            public int? IdAdministrativo { get; set; }
        }
    }
}