using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Modelos;

namespace AccesoDatosWM
{
    public static class ArbitroRepositorio
    {
        public static List<Arbitro> ObtenerArbitros()
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = "SELECT ID_ARBITRO AS IdArbitro, E.NOMBRE, E.APELLIDO FROM ARBITRO A JOIN EMPLEADO E ON A.ID_EMPLEADO = E.ID_EMPLEADO";
                return conexion.Query<Arbitro>(sql).ToList();
            }
        }
    }
}
