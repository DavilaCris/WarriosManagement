using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosWM;
using Dapper;
using Modelos;


namespace AccesoDatosWM
{
    public static class RepositorioTorneos
    {
        public static List<Torneo> ListarTorneos()
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
                    SELECT 
                        ID_TORNEO AS IdTorneo,
                        NOMBRE AS Nombre,
                        CIUDAD AS Ciudad,
                        CALLE AS Calle,
                        NUMERO_CALLE AS NumeroCalle,
                        COD_POSTAL AS CodPostal,
                        FECHA AS Fecha
                    FROM TORNEO";

                return conexion.Query<Torneo>(sql).ToList();
            }
        }

        public static void GuardarTorneo(Torneo torneo)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
                    INSERT INTO TORNEO (NOMBRE, CIUDAD, CALLE, NUMERO_CALLE, COD_POSTAL, FECHA)
                    VALUES (@Nombre, @Ciudad, @Calle, @NumeroCalle, @CodPostal, @Fecha)";

                conexion.Execute(sql, torneo);
            }
        }

        public static void EliminarTorneo(int idTorneo)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = "DELETE FROM TORNEO WHERE ID_TORNEO = @IdTorneo";
                conexion.Execute(sql, new { IdTorneo = idTorneo });
            }
        }

        public static int? BuscarIdTorneoPorFecha(DateTime fecha)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string query = @"
                    SELECT ID_TORNEO
                    FROM TORNEO
                    WHERE FECHA = @Fecha";

                return conexion.QueryFirstOrDefault<int?>(query, new { Fecha = fecha });
            }
        }
    }
}