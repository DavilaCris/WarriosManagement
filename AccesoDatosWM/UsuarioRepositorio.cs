using System;
using System.Linq;
using Dapper;
using Modelos;
using Modelos.Modelos;

namespace AccesoDatosWM
{
    public class UsuarioRepositorio
    {
        public static Usuario ObtenerUsuarioPorEmail(string email)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
                    SELECT 
                        ID_USUARIO AS IdUsuario,
                        EMAIL AS Email,
                        CONTRASENA_HASH AS ContrasenaHash,
                        TIPO_USUARIO AS TipoUsuario,
                        ID_ATLETA AS IdAtleta,
                        ID_ARBITRO AS IdArbitro,
                        ID_STAFF AS IdStaff,
                        ID_ENTRENADOR AS IdEntrenador,
                        ID_ADMINISTRATIVO AS IdAdministrativo
                    FROM USUARIOS
                    WHERE EMAIL = @Email";

                return conexion.Query<Usuario>(sql, new { Email = email }).FirstOrDefault();
            }
        }

        public static bool CrearUsuarioAdministrativo(Usuario usuario)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
                    INSERT INTO USUARIOS (
                        EMAIL, CONTRASENA_HASH, TIPO_USUARIO, ID_ENTRENADOR
                    )
                    VALUES (
                        @Email, @ContrasenaHash, @TipoUsuario, @IdStaff
                    )";

                var parametros = new
                {
                    Email = usuario.Email,
                    ContrasenaHash = usuario.ContrasenaHash,
                    TipoUsuario = usuario.TipoUsuario,
                    IdStaff = usuario.IdStaff
                };

                try
                {
                    int filasAfectadas = conexion.Execute(sql, parametros);
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar usuario: " + ex.Message);
                    return false;
                }
            }
        }
        public static bool CrearUsuarioStaff(Usuario usuario)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
            INSERT INTO USUARIOS (
                EMAIL, CONTRASENA_HASH, TIPO_USUARIO, ID_STAFF
            )
            VALUES (
                @Email, @ContrasenaHash, @TipoUsuario, @IdStaff
            )";

                var parametros = new
                {
                    Email = usuario.Email,
                    ContrasenaHash = usuario.ContrasenaHash,
                    TipoUsuario = usuario.TipoUsuario,  // Debe ser "STAFF"
                    IdStaff = usuario.IdStaff
                };

                try
                {
                    int filasAfectadas = conexion.Execute(sql, parametros);
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar usuario STAFF: " + ex.Message);
                    return false;
                }
            }
        }

        public static int? ExtraerAtleta(int idUsuario)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"SELECT ID_ATLETA FROM USUARIOS WHERE ID_USUARIO = @IdUsuario AND ID_ATLETA IS NOT NULL;";
                return conexion.Query<int?>(sql, new { IdUsuario = idUsuario }).FirstOrDefault();
            }
        }

        public static int? ExtraerAdministrativo(int idUsuario)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"SELECT ID_ADMINISTRATIVO FROM USUARIOS WHERE ID_USUARIO = @IdUsuario AND ID_ADMINISTRATIVO IS NOT NULL;";
                return conexion.Query<int?>(sql, new { IdUsuario = idUsuario }).FirstOrDefault();
            }
        }

        public static int? ExtraerEntrenador(int idUsuario)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"SELECT ID_ENTRENADOR FROM USUARIOS WHERE ID_USUARIO = @IdUsuario AND ID_ENTRENADOR IS NOT NULL;";
                return conexion.Query<int?>(sql, new { IdUsuario = idUsuario }).FirstOrDefault();
            }
        }

        public static int? ExtraerStaff(int idUsuario)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"SELECT ID_STAFF FROM USUARIOS WHERE ID_USUARIO = @IdUsuario AND ID_STAFF IS NOT NULL;";
                return conexion.Query<int?>(sql, new { IdUsuario = idUsuario }).FirstOrDefault();
            }
        }
        

    }

    }



