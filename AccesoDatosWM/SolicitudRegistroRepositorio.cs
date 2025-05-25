using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Modelos;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace AccesoDatosWM
{
    public class SolicitudRegistroRepositorio
    {
        public static int AltaSolicitudRegistro(SolicitudRegistro solicitud)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = "";
                sql += "INSERT INTO [dbo].[SOLICITUD_REGISTRO] " + "\n";
                sql += "       ([NOMBRE] " + "\n";
                sql += "       ,[APELLIDO] " + "\n";
                sql += "       ,[DNI] " + "\n";
                sql += "       ,[FECHA_NACIMIENTO] " + "\n";
                sql += "       ,[NACIONALIDAD] " + "\n";
                sql += "       ,[CINTURON] " + "\n";
                sql += "       ,[ID_CATEGORIA] " + "\n";
                sql += "       ,[PUNTOS] " + "\n";
                sql += "       ,[EN_RANKING] " + "\n";
                sql += "       ,[ID_ENTRENADOR] " + "\n";
                sql += "       ,[IMAGEN] " + "\n";
                sql += "       ,[LATERALIDAD] " + "\n";
                sql += "       ,[PESO] " + "\n";
                sql += "       ,[ALTURA] " + "\n";
                sql += "       ,[EMAIL] " + "\n";
                sql += "       ,[CONTRASENA_HASH] " + "\n";
                sql += "       ,[TIPO_USUARIO_SOLICITADO]) " + "\n";
                sql += "VALUES " + "\n";
                sql += "       (@Nombre " + "\n";
                sql += "       ,@Apellido " + "\n";
                sql += "       ,@Dni " + "\n";
                sql += "       ,@FechaNacimiento " + "\n";
                sql += "       ,@Nacionalidad " + "\n";
                sql += "       ,@Cinturon " + "\n";
                sql += "       ,@IdCategoria " + "\n";
                sql += "       ,@Puntos " + "\n";
                sql += "       ,@EnRanking " + "\n";
                sql += "       ,@IdEntrenador " + "\n";
                sql += "       ,@Imagen " + "\n";
                sql += "       ,@Lateralidad " + "\n";
                sql += "       ,@Peso " + "\n";
                sql += "       ,@Altura " + "\n";
                sql += "       ,@Email " + "\n";
                sql += "       ,@ContrasenaHash " + "\n";
                sql += "       ,@TipoUsuarioSolicitado)";

                var insertadas = conexion.Execute(sql, new
                {
                    solicitud.Nombre,
                    solicitud.Apellido,
                    solicitud.Dni,
                    solicitud.FechaNacimiento,
                    solicitud.Nacionalidad,
                    solicitud.Cinturon,
                    solicitud.IdCategoria,
                    solicitud.Puntos,
                    solicitud.EnRanking,
                    solicitud.IdEntrenador,
                    solicitud.Imagen,
                    solicitud.Lateralidad,
                    solicitud.Peso,
                    solicitud.Altura,
                    solicitud.Email,
                    solicitud.ContrasenaHash,
                    solicitud.TipoUsuarioSolicitado
                });

                return insertadas;
            }
        }
        public static List<SolicitudRegistroSinImagen> ObtenerSolicitudes()
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
            SELECT
                ID_SOLICITUD AS IdSolicitud,
                NOMBRE,
                APELLIDO,
                DNI,
                FECHA_NACIMIENTO AS FechaNacimiento,
                NACIONALIDAD,
                CINTURON,
                ID_CATEGORIA AS IdCategoria,
                PUNTOS,
                EN_RANKING AS EnRanking,
                ID_ENTRENADOR AS IdEntrenador,
                LATERALIDAD,
                PESO,
                ALTURA,
                FECHA_SOLICITUD AS FechaSolicitud,
                APROBADO,
                EMAIL,
                TIPO_USUARIO_SOLICITADO AS TipoUsuarioSolicitado
            FROM SOLICITUD_REGISTRO
            WHERE APROBADO = 0";

                return conexion.Query<SolicitudRegistroSinImagen>(sql).ToList();
            }
        }

        public static bool ExisteCorreo(string correo)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = "SELECT COUNT(*) FROM SOLICITUD_REGISTRO WHERE EMAIL = @correo";
                int count = conexion.ExecuteScalar<int>(sql, new { correo });
                return count > 0;
            }
        }
        public static bool ExisteDni(string dni)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = "SELECT COUNT(*) FROM SOLICITUD_REGISTRO WHERE DNI = @dni";
                int count = conexion.ExecuteScalar<int>(sql, new { dni });
                return count > 0;
            }
        }

        public static void AprobarSolicitud(int idSolicitud)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = "UPDATE SOLICITUD_REGISTRO SET APROBADO = 1 WHERE ID_SOLICITUD = @IdSolicitud";
                conexion.Execute(sql, new { IdSolicitud = idSolicitud });
            }
        }

        public static void EliminarSolicitud(int idSolicitud)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = "DELETE FROM SOLICITUD_REGISTRO WHERE ID_SOLICITUD = @IdSolicitud";
                conexion.Execute(sql, new { IdSolicitud = idSolicitud });
            }
        }
    }


}

