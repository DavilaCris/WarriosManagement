using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Modelos;
namespace AccesoDatosWM
{
    public static class HistorialRepositorio
    {
        public static List<HistorialEnfrentamiento> ObtenerHistorialPorAtleta(int idAtleta)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
                    SELECT ResultadoFormateado 
                    FROM Vista_Historial_Atleta_Enfrentamientos 
                    WHERE ID_AKA = @id OR ID_AO = @id";

                return conexion.Query<HistorialEnfrentamiento>(sql, new { id = idAtleta }).ToList();
            }
        }
    }
}