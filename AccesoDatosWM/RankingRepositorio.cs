using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using AccesoDatosWM;
using Dapper;

namespace AccesoDatosWM
{
   public class RankingRepositorio
    {
        public static List<RankingAtleta> ObtenerRankingPorCategoria(int idCategoria)
        {
            var ranking = new List<RankingAtleta>();

            using (var conexion = Connexion.GetSqlConnection())
            {
                string query = @"
                    SELECT 
                        ID_ATLETA,
                        NOMBRE,
                        APELLIDO,
                        DNI,
                        FECHA_NACIMIENTO,
                        NACIONALIDAD,
                        CINTURON,
                        PUNTOS,
                        LATERALIDAD,
                        PESO,
                        NOMBRE_CATEGORIA,
                        POSICION
                    FROM Vista_RankingAtletasPorCategoria
                    WHERE ID_CATEGORIA = @idCategoria
                    ORDER BY POSICION ASC";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var atleta = new RankingAtleta
                    {  IdAtleta = Convert.ToInt32(reader["ID_ATLETA"]),
                        Nombre = reader["NOMBRE"].ToString(),
                        Apellido = reader["APELLIDO"].ToString(),
                        DNI = reader["DNI"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(reader["FECHA_NACIMIENTO"]),
                        Nacionalidad = reader["NACIONALIDAD"].ToString(),
                        Cinturon = reader["CINTURON"].ToString(),
                        Puntos = Convert.ToInt32(reader["PUNTOS"]),
                        Lateralidad = reader["LATERALIDAD"].ToString(),
                        Peso = Convert.ToDouble(reader["PESO"]),

                        NombreCategoria = reader["NOMBRE_CATEGORIA"].ToString(),
                        Posicion = Convert.ToInt32(reader["POSICION"])
                    };

                    ranking.Add(atleta);
                }

                reader.Close();
            }

            return ranking;
        }

        public static List<RankingAtleta> BuscarRankingPorNombre(string nombre)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string consulta = @"
                    SELECT 
                        ID_ATLETA,
                        NOMBRE,
                        APELLIDO,
                        DNI,
                        FECHA_NACIMIENTO,
                        NACIONALIDAD,
                        CINTURON,
                        PUNTOS,
                        LATERALIDAD,
                        PESO,
                        ALTURA,
                        ID_CATEGORIA,
                        NOMBRE_CATEGORIA,
                        POSICION
                    FROM Vista_RankingAtletasPorCategoria
                    WHERE LOWER(NOMBRE) LIKE '%' + LOWER(@Nombre) + '%'
                ";

                return conexion.Query<RankingAtleta>(consulta, new { Nombre = nombre }).ToList();
            }
        }
    }
}
