using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarriosManagement
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new AprobacionAltas());
            //Application.Run(new SolicitudAlta());
            //Application.Run(new AprobacionAltas());
            //Application.Run(new ListaEntrenadores());
            //Application.Run(new AltaCampeonato());
            Application.Run(new Login());
            //Application.Run(new VistaRankingPorCategoria());
            //Application.Run(new VistaAtleta());
        }
    }
}
