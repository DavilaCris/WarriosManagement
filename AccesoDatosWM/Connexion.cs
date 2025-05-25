using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosWM
{
    public class Connexion
    {
        //esto os sirve para extraer la cadena de conexion de App.config
       private static string ConnectionString
        {
            get {
                return ConfigurationManager
                        .ConnectionStrings["WMConnetionString"]
                        .ConnectionString;
            }
        }
        //esto nos sirve para crear la conexion y abrirla pasandole la cadena de conexion
        public static SqlConnection GetSqlConnection() { 
        var conexion = new SqlConnection (ConnectionString);
            conexion.Open ();
            return conexion;
        
        }
    }
    
}
