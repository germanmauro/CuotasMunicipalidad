using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Datos
{
    public class DatosDB
    {
        public static int ExecuteNonQuery(string comando)
        {
            try
            {
                Conexion.cn = new OleDbConnection(Conexion.cadena);
                OleDbCommand cm = new OleDbCommand(comando, Conexion.cn);
                Conexion.cn.Open();
                int cantidad = cm.ExecuteNonQuery();
                Conexion.cn.Close();
                Conexion.cn.Dispose();
                return cantidad;
            }
            catch (Exception ex)
            {
                string cadena = ex.Message;
                return -1;
                            
            }
            finally
            {
                Conexion.cn.Close();
                Conexion.cn.Dispose();
            }
        }

        public static int ExecuteScalar(string comando)
        {
            try
            {
                Conexion.cn = new OleDbConnection(Conexion.cadena);
                OleDbCommand cm = new OleDbCommand(comando, Conexion.cn);
                Conexion.cn.Open();
                int cantidad = int.Parse(cm.ExecuteScalar().ToString());
                Conexion.cn.Close();
                Conexion.cn.Dispose();
                return cantidad;
            }
            catch (Exception ex)
            {
                string cadena = ex.Message;
                return 0;

            }
            finally
            {
                Conexion.cn.Close();
                Conexion.cn.Dispose();
            }
        }

        private static DataTable GenerarDataTable(string comando)
        {
            try
            {
                Conexion.cn = new OleDbConnection(Conexion.cadena);
                OleDbCommand cm = new OleDbCommand(comando, Conexion.cn);
                Conexion.cn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Conexion.cn.Close();
                Conexion.cn.Dispose();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message,ex);
            }
            finally
            {
                Conexion.cn.Close();
                Conexion.cn.Dispose();
            }
            
        }

        public static bool Actualizar(string tabla, Dictionary<string, string> parametros, Dictionary<string, string> condicion)
        {
            StringBuilder cadena = new StringBuilder();
            if (parametros.Count > 0)
            {
                cadena.Append("update ");
                cadena.Append(tabla);
                cadena.Append(" set ");
                for (int i = 0; i < parametros.Count; i++)
                {
                    cadena.Append(parametros.ElementAt(i).Key);
                    cadena.Append("=");
                    cadena.Append(parametros.ElementAt(i).Value);
                    if (i < parametros.Count-1)
                    {
                        cadena.Append(",");
                    }
                }
                if (condicion != null && condicion.Count > 0)
                {
                    cadena.Append(" where ");

                    for (int i = 0; i < condicion.Count; i++)
                    {

                        cadena.Append(condicion.ElementAt(i).Key);
                        cadena.Append("=");
                        cadena.Append(condicion.ElementAt(i).Value);
                        if (i < condicion.Count-1)
                        {
                            cadena.Append(" AND ");
                        }
                    }
                }
            }
            if(ExecuteNonQuery(cadena.ToString()) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool Insertar(string tabla, Dictionary<string, string> parametros)
        {
            StringBuilder cadena = new StringBuilder();
            if (parametros.Count > 0)
            {
                cadena.Append("insert into ");
                cadena.Append(tabla);
                cadena.Append(" (");
                for (int i = 0; i < parametros.Count; i++)
                {
                    cadena.Append(parametros.ElementAt(i).Key);
                    if (i < parametros.Count-1)
                    {
                        cadena.Append(",");
                    }
                    else
                    {
                        cadena.Append(")");
                    }
                }
                cadena.Append(" Values(");
                for (int i = 0; i < parametros.Count; i++)
                {
                    cadena.Append(parametros.ElementAt(i).Value);
                    if (i < parametros.Count-1)
                    {
                        cadena.Append(",");
                    }
                    else
                    {
                        cadena.Append(")");
                    }
                }
            }
            if(ExecuteNonQuery(cadena.ToString())>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Borrar(string tabla, Dictionary<string, string> parametros)
        {
            StringBuilder cadena = new StringBuilder();
            if (parametros.Count > 0)
            {
                cadena.Append("delete from ");
                cadena.Append(tabla);
                cadena.Append(" where ");
                for (int i = 0; i < parametros.Count; i++)
                {
                    cadena.Append(parametros.ElementAt(i).Key);
                    cadena.Append("=");
                    cadena.Append(parametros.ElementAt(i).Value);
                    if (i < parametros.Count-1)
                    {
                        cadena.Append(" AND ");
                    }
                }            
            }
            if(ExecuteNonQuery(cadena.ToString()) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool BajaLogica(string tabla, Dictionary<string, string> parametros)
        {
            StringBuilder cadena = new StringBuilder();
            if (parametros.Count > 0)
            {
                cadena.Append("update ");
                cadena.Append(tabla);
                cadena.Append(" set baja=True where ");
                for (int i = 0; i < parametros.Count; i++)
                {
                    cadena.Append(parametros.ElementAt(i).Key);
                    cadena.Append("=");
                    cadena.Append(parametros.ElementAt(i).Value);
                    if (i < parametros.Count-1)
                    {
                        cadena.Append(" AND ");
                    }
                }
            }
            if(ExecuteNonQuery(cadena.ToString()) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerificarExistente(string tabla, Dictionary<string, string> parametros, Dictionary<string, string> diferenciales = null)
        {
            StringBuilder cadena = new StringBuilder();
            if (parametros.Count > 0)
            {
                cadena.Append("select count(*) from ");
                cadena.Append(tabla);
                cadena.Append(" where ");
                for (int i = 0; i < parametros.Count; i++)
                {
                    cadena.Append(parametros.ElementAt(i).Key);
                    cadena.Append("=");
                    cadena.Append(parametros.ElementAt(i).Value);
                    if (i < parametros.Count - 1)
                    {
                        cadena.Append(" AND ");
                    }
                }
                if (diferenciales != null && diferenciales.Count > 0)
                {
                    cadena.Append(" AND ");
                    for (int i = 0; i < diferenciales.Count; i++)
                    {
                        cadena.Append(diferenciales.ElementAt(i).Key);
                        cadena.Append("<>");
                        cadena.Append(diferenciales.ElementAt(i).Value);
                        if (i < parametros.Count - 1)
                        {
                            cadena.Append(" AND ");
                        }
                    }
                }
            }
            if(ExecuteScalar(cadena.ToString())>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable Listar(string tabla, Dictionary<string, string> parametros)
        {
            StringBuilder cadena = new StringBuilder();
            
            cadena.Append("select * from ");
            cadena.Append(tabla);
            if (parametros != null && parametros.Count > 0)
            {
                cadena.Append(" where ");
                for (int i = 0; i < parametros.Count; i++)
                {
                    cadena.Append(parametros.ElementAt(i).Key);
                    cadena.Append("=");
                    cadena.Append(parametros.ElementAt(i).Value);
                    if (i < parametros.Count - 1)
                    {
                        cadena.Append(" AND ");
                    }
                }
            }
            return GenerarDataTable(cadena.ToString());
        }

        public static DataTable ListarComandoDirecto(string comando)
        {
            return GenerarDataTable(comando);
        }
    }
}
