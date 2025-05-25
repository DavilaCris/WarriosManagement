using System.Collections.Generic;
using System.Linq;
using Dapper;
using Modelos;
using System;

namespace AccesoDatosWM
{
    public class EnfrentamientoRepositorio
    {
        public static List<Enfrentamiento> ListarEnfrentamientosPorUsuario(int idUsuario)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
                    SELECT 
                        ID_ENFRENTAMIENTO AS IdEnfrentamiento,
                        ID_ATLETA_AKA AS IdAtletaAka,
                        ID_ATLETA_AO AS IdAtletaAo,
                        ID_ARBITRO_CENTRAL AS IdArbitroCentral,
                        ID_ARBITRO_1 AS IdArbitro1,
                        ID_ARBITRO_2 AS IdArbitro2,
                        ID_ARBITRO_3 AS IdArbitro3,
                        ID_ARBITRO_4 AS IdArbitro4,
                        ID_STAFF AS IdStaff,
                        ID_GANADOR AS IdGanador,
                        FECHA AS Fecha,
                        ID_TORNEO AS IdTorneo,
                        ID_CATEGORIA AS IdCategoria
                    FROM ENFRENTAMIENTOS
                    WHERE ID_ATLETA_AKA = @Id OR ID_ATLETA_AO = @Id
                    ORDER BY FECHA DESC";

                return conexion.Query<Enfrentamiento>(sql, new { Id = idUsuario }).ToList();
            }
        }

        public static void GuardarEnfrentamiento(Enfrentamiento enfrentamiento)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
                    INSERT INTO ENFRENTAMIENTOS (
                        ID_ATLETA_AKA,
                        ID_ATLETA_AO,
                        ID_ARBITRO_CENTRAL,
                        ID_ARBITRO_1,
                        ID_ARBITRO_2,
                        ID_ARBITRO_3,
                        ID_ARBITRO_4,
                        ID_STAFF,
                        ID_TORNEO,
                        ID_CATEGORIA
                    ) VALUES (
                        @IdAtletaAka,
                        @IdAtletaAo,
                        @IdArbitroCentral,
                        @IdArbitro1,
                        @IdArbitro2,
                        @IdArbitro3,
                        @IdArbitro4,
                        @IdStaff,
                        @IdTorneo,
                        @IdCategoria
                    );";

                conexion.Execute(sql, enfrentamiento);
            }
        }
        public static string ObtenerNombreGanadorActual(int idEnfrentamiento)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
                    SELECT A.NOMBRE + ' ' + A.APELLIDO AS NombreCompleto
                    FROM ENFRENTAMIENTOS E
                    INNER JOIN ATLETA A ON E.ID_GANADOR = A.ID_ATLETA
                    WHERE E.ID_ENFRENTAMIENTO = @Id";

                return conexion.QueryFirstOrDefault<string>(sql, new { Id = idEnfrentamiento });
            }
        }
        public static string ObtenerMarcadorDesdeVista(int idEnfrentamiento)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
            SELECT MARCADOR
            FROM VISTA_MARCADOR_ENFRENTAMIENTO
            WHERE ID_ENFRENTAMIENTO = @id";

                return conexion.QueryFirstOrDefault<string>(sql, new { id = idEnfrentamiento }) ?? "Sin marcador";
            }
        }
        public static Enfrentamiento ObtenerResumen(int idAtleta)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
                    SELECT 
                        -- Total donde participó
                        (SELECT COUNT(*) 
                         FROM ENFRENTAMIENTOS 
                         WHERE ID_ATLETA_AKA = @id OR ID_ATLETA_AO = @id) AS Totales,

                        -- Total ganados
                        (SELECT COUNT(*) 
                         FROM ENFRENTAMIENTOS 
                         WHERE ID_GANADOR = @id) AS Ganados,

                        -- Total perdidos
                        (SELECT COUNT(*) 
                         FROM ENFRENTAMIENTOS 
                         WHERE ID_GANADOR IS NOT NULL 
                           AND (ID_ATLETA_AKA = @id OR ID_ATLETA_AO = @id) 
                           AND ID_GANADOR <> @id) AS Perdidos;";

                return conexion.QuerySingle<Enfrentamiento>(sql, new { id = idAtleta });
            }
        }

    }
}
