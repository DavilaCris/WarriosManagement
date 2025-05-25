using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Modelos;

namespace AccesoDatosWM
{
    public class CategoriaRepositorio
    {
        public static List<Categoria> ObtenerCategorias()
        {
            using (var conexion = Connexion.GetSqlConnection())
            {
                string sql = "SELECT ID_CATEGORIA AS IdCategoria, NOMBRE AS Nombre FROM CATEGORIA";

                var lista = conexion.Query<Categoria>(sql).ToList();
                return lista;
            }
        }
    }
}
