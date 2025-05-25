using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Modelos;


namespace AccesoDatosWM
{
 
    public class AtletaRepositorio
    {
        //metodo que sirve para la solicitud de alta del atleta
        public int AltaAtleta(Atleta atleta) {
            using (var conexion = Connexion.GetSqlConnection()) {
                String sql = "";
                sql = sql + "INSERT INTO [dbo].[ATLETA] " + "\n";
                sql = sql + "           ([NOMBRE] " + "\n";
                sql = sql + "           ,[APELLIDO] " + "\n";
                sql = sql + "           ,[FECHA_NACIMIENTO] " + "\n";
                sql = sql + "           ,[NACIONALIDAD] " + "\n";
                sql = sql + "           ,[CINTURON] " + "\n";
                sql = sql + "           ,[ID_CATEGORIA] " + "\n";
                sql = sql + "           ,[ID_ENTRENADOR] " + "\n";
                sql = sql + "           ,[IMAGEN]) " + "\n";
                sql = sql + "     VALUES " + "\n";
                sql = sql + "           (@nombre " + "\n";
                sql = sql + "           ,@apellido " + "\n";
                sql = sql + "           ,@fechaNacimiento " + "\n";
                sql = sql + "           ,@nacionalidad " + "\n";
                sql = sql + "           ,@cinturon " + "\n";
                sql = sql + "           ,@categoria " + "\n";
                sql = sql + "           ,@entrenador " + "\n";
                sql = sql + "           ,@foto)";

                var insertadas = conexion.Execute(sql, new
                {
                    nombre = atleta.Nombre,
                    apellido = atleta.Apellido,
                    fechaNacimiento = atleta.FechaNacimiento,
                    nacionalidad = atleta.Nacionalidad,
                    cinturon = atleta.Cinturon,
                    categoria = atleta.IdCategoria,
                    entrenador = atleta.IdEntrenador,
                    foto = atleta.Imagen
                });
                return insertadas;
            }
       

        }

       
            public static List<Atleta> ObtenerAtletas()
            {
                using (var conexion = Connexion.GetSqlConnection())
                {
                    string sql = "SELECT ID_ATLETA AS IdAtleta, NOMBRE, APELLIDO FROM ATLETA";
                    return conexion.Query<Atleta>(sql).ToList();
                }
            }

        public static Atleta ObtenerAtletaPorId(int idAtleta)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
            SELECT 
                a.ID_ATLETA AS IdAtleta,
                a.NOMBRE,
                a.APELLIDO,
                a.FECHA_NACIMIENTO,
                a.NACIONALIDAD,
                a.CINTURON,
                a.LATERALIDAD,
                a.PESO,
                a.ALTURA,
                a.ID_CATEGORIA AS IdCategoria,
                a.ID_ENTRENADOR AS IdEntrenador,
                a.IMAGEN,
                r.POSICION,
                c.NOMBRE AS NombreCategoria
            FROM ATLETA a
            LEFT JOIN RANKING r ON a.ID_ATLETA = r.ID_ATLETA
            LEFT JOIN CATEGORIA c ON a.ID_CATEGORIA = c.ID_CATEGORIA
            WHERE a.ID_ATLETA = @id";

                return conexion.QueryFirstOrDefault<Atleta>(sql, new { id = idAtleta });
            }
        }
        public static List<Atleta> ObtenerAtletasPorEntrenador(int idEntrenador)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
            SELECT 
                ID_ATLETA AS IdAtleta,
                NOMBRE,
                APELLIDO
            FROM ATLETA
            WHERE ID_ENTRENADOR = @id
            ORDER BY APELLIDO, NOMBRE";

                return conexion.Query<Atleta>(sql, new { id = idEntrenador }).ToList();
            }
        }

    }
}
