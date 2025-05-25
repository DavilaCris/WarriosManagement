using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Modelos;

namespace AccesoDatosWM
{
    public  class EntrenadorRepositorio
    {
        public static int GuardarEntrenador(Entrenador entrenador)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = "";
                sql += "INSERT INTO [dbo].[ENTRENADOR] " + "\n";
                sql += "       ([NOMBRE] " + "\n";
                sql += "       ,[APELLIDO] " + "\n";
                sql += "       ,[FECHA_NACIMIENTO] " + "\n";
                sql += "       ,[NACIONALIDAD] " + "\n";
                sql += "       ,[CINTURON] " + "\n";
                sql += "       ,[CIUDAD] " + "\n";
                sql += "       ,[NUMERO_CALLE] " + "\n";
                sql += "       ,[COD_POSTAL]) " + "\n";
                sql += " VALUES " + "\n";
                sql += "       (@nombre " + "\n";
                sql += "       ,@apellido " + "\n";
                sql += "       ,@fechaNacimiento " + "\n";
                sql += "       ,@nacionalidad " + "\n";
                sql += "       ,@cinturon " + "\n";
                sql += "       ,@ciudad " + "\n";
                sql += "       ,@numeroCalle " + "\n";
                sql += "       ,@codPostal)";

                var insertadas = conexion.Execute(sql, new
                {
                    nombre = entrenador.Nombre,
                    apellido = entrenador.Apellido,
                    fechaNacimiento = entrenador.FechaNacimiento,
                    nacionalidad = entrenador.Nacionalidad,
                    cinturon = entrenador.Cinturon,
                    ciudad = entrenador.Ciudad,
                    numeroCalle = entrenador.NumeroCalle,
                    codPostal = entrenador.CodPostal
                });

                return insertadas;
            }
        }

        public static  List<Entrenador> ObtenerEntrenadorNombreApellidoEscuela()
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
            SELECT 
                ID_ENTRENADOR AS IDEntrenador,
                NOMBRE,
                APELLIDO,
                ESCUELA
            FROM ENTRENADOR";

                return conexion.Query<Entrenador>(sql).ToList();

            }
        }

        public static List<Entrenador> ObtenerEntrenadores()
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"SELECT * FROM ENTRENADOR";
                return conexion.Query<Entrenador>(sql).ToList();
            }
        }

        public static bool EliminarEntrenador(int idEntrenador)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = "DELETE FROM ENTRENADOR WHERE ID_ENTRENADOR = @Id";
                return conexion.Execute(sql, new { Id = idEntrenador }) > 0;
            }
        }

        public static bool ModificarEntrenador(Entrenador entrenador)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
                    UPDATE ENTRENADOR SET
                        NOMBRE = @Nombre,
                        APELLIDO = @Apellido,
                        FECHA_NACIMIENTO = @FechaNacimiento,
                        NACIONALIDAD = @Nacionalidad,
                        CINTURON = @Cinturon,
                        CIUDAD = @Ciudad,
                        NUMERO_CALLE = @NumeroCalle,
                        COD_POSTAL = @CodPostal,
                        ESCUELA = @Escuela
                    WHERE ID_ENTRENADOR = @IdEntrenador";

                return conexion.Execute(sql, entrenador) > 0;
            }
        }
    }
}
