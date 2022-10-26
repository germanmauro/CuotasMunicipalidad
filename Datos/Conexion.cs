using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Conexion
    {
        public static SqlConnection cn;
        //public static string cadena = ConfigurationManager.ConnectionStrings["conexion"].ToString();
        public static string cadena = "Data Source=.;Initial Catalog=Cuotas;User ID=german Password=12345678;";
    }
}
