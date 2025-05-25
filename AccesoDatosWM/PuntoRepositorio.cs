using System;
using Dapper;
using System.Data.SqlClient;
using Modelos;

namespace AccesoDatosWM
{
    public static class PuntosRepositorio
    {
        public static bool GuardarPunto(Punto punto)
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = @"
                    INSERT INTO PUNTOS (
                        ID_ENFRENTAMIENTO, 
                        ID_ATLETA, 
                        ACCION, 
                        EXTREMIDAD, 
                        LATERALIDAD, 
                        CANTIDAD_BANDERAS
                    )
                    VALUES (
                        @IdEnfrentamiento, 
                        @IdAtleta, 
                        @Accion, 
                        @Extremidad, 
                        @Lateralidad, 
                        @CantidadBanderas
                    );";

                try
                {
                    int filasAfectadas = conexion.Execute(sql, new
                    {
                        punto.IdEnfrentamiento,
                        punto.IdAtleta,
                        punto.Accion,
                        punto.Extremidad,
                        punto.Lateralidad,
                        punto.CantidadBanderas
                    });

                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar punto: " + ex.Message);
                    return false;
                }
            }
        }

        public static int ObtenerUltimoEnfrentamiento()
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = "SELECT MAX(ID_ENFRENTAMIENTO) FROM ENFRENTAMIENTOS";
                return conexion.ExecuteScalar<int>(sql);
            }
        }
    

}
}
