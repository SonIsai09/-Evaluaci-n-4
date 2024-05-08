using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Celulares
{
    internal class Conexion
    {

        public static SqlConnection ConexionSql() {
            string cadena = "server= localhost;database=Celulares; integrated security= true";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;

        }
    }
}
