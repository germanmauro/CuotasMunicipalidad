using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Conexion
    {
        public static OleDbConnection cn;
        public static OleDbConnection cnMySQL;
        //public static string cadena = ConfigurationManager.ConnectionStrings["conexion"].ToString();
        public static string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = AppData/DB1.mdb;Jet OLEDB:Database Password=melany01;";
        public static string cadenaMySQL = "Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;";
    }
}
