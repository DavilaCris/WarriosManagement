using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AccesoDatosWM
{
    public class EstadisticasRepositorio
    {
        public static int ObtenerTotalEnfrentamientos(int idAtleta)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"SELECT COUNT(*) 
                               FROM ENFRENTAMIENTOS 
                               WHERE ID_ATLETA_AKA = @id OR ID_ATLETA_AO = @id";
                return conexion.ExecuteScalar<int>(sql, new { id = idAtleta });
            }
        }

        public static int ObtenerTotalPuntos(int idAtleta)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"SELECT COUNT(*) 
                               FROM PUNTOS 
                               WHERE ID_ATLETA = @id";
                return conexion.ExecuteScalar<int>(sql, new { id = idAtleta });
            }
        }

        public static int ObtenerTotalLesiones(int idAtleta)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"SELECT COUNT(*)
                               FROM PUNTOS
                               WHERE ID_ATLETA = @id AND ACCION = 'LESION'";
                return conexion.ExecuteScalar<int>(sql, new { id = idAtleta });
            }
        }

        public static Dictionary<string, int> ObtenerPuntosPorTipo(int idAtleta)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"SELECT ACCION AS Clave, COUNT(*) AS Total
                               FROM PUNTOS
                               WHERE ID_ATLETA = @id AND ACCION IN ('IPPON', 'WAZAARI', 'YUKO')
                               GROUP BY ACCION";

                var resultados = conexion.Query<ParejaClaveValor>(sql, new { id = idAtleta });
                return resultados.ToDictionary(r => r.Clave, r => r.Total);
            }
        }

        public static Dictionary<string, int> ObtenerFaltasPorTipo(int idAtleta)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"SELECT ACCION AS Clave, COUNT(*) AS Total
                               FROM PUNTOS
                               WHERE ID_ATLETA = @id AND ACCION IN ('CHUKOKU', 'KEYOKU', 'HANSOKU_CHUI', 'HANSOKU')
                               GROUP BY ACCION";

                var resultados = conexion.Query<ParejaClaveValor>(sql, new { id = idAtleta });
                return resultados.ToDictionary(r => r.Clave, r => r.Total);
            }
        }

        public static Dictionary<string, int> ObtenerPuntosPorExtremidadYLateralidad(int idAtleta)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"SELECT (EXTREMIDAD + '_' + LATERALIDAD) AS Clave, COUNT(*) AS Total
                               FROM PUNTOS
                               WHERE ID_ATLETA = @id AND ACCION IN ('IPPON', 'WAZAARI', 'YUKO')
                               GROUP BY EXTREMIDAD, LATERALIDAD";

                var resultados = conexion.Query<ParejaClaveValor>(sql, new { id = idAtleta });
                return resultados.ToDictionary(r => r.Clave, r => r.Total);
            }
        }
    }

    public class ParejaClaveValor
    {
        public string Clave { get; set; }
        public int Total { get; set; }
    }
}
