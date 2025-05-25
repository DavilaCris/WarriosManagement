using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Modelos;

namespace AccesoDatosWM
{
    public class MensajeRepositorio
    {
        public static void GuardarMensaje(Mensaje mensaje)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
                INSERT INTO MENSAJES (ID_EMISOR, ID_RECEPTOR, TEXTO, FECHA_HORA, LEIDO)
                VALUES (@IdEmisor, @IdReceptor, @Texto)";

                conexion.Execute(sql, new
                {
                    IdEmisor = mensaje.IdEmisor,
                    IdReceptor = mensaje.IdReceptor,
                    Texto = mensaje.Texto,
               
                });
            }
        }

        public static List<Mensaje> ObtenerConversacion(int idUsuario1, int idUsuario2)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
            SELECT 
                ID_MENSAJE AS IdMensaje,
                ID_EMISOR AS IdEmisor,
                ID_RECEPTOR AS IdReceptor,
                TEXTO AS Texto,
                FECHA_HORA AS FechaHora,
                LEIDO AS Leido
            FROM MENSAJES
            WHERE (ID_EMISOR = @Id1 AND ID_RECEPTOR = @Id2)
               OR (ID_EMISOR = @Id2 AND ID_RECEPTOR = @Id1)
            ORDER BY FECHA_HORA";

                return conexion.Query<Mensaje>(sql, new { Id1 = idUsuario1, Id2 = idUsuario2 }).ToList();
            }
        }
    }
}
