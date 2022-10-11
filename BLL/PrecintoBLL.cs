using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class PrecintoBLL
    {
        public static bool Guardar(Entidades.Precinto dt)
        {
            try
            {
                Dictionary<string, string> parametros = new Dictionary<string, string>();

                parametros.Add("Baja", "False");

                parametros.Add("Fecha", Utilidades.AgregarComillas(dt.Fecha));
                parametros.Add("Unidad", Utilidades.AgregarComillas(dt.Unidad));
                parametros.Add("Chofer", Utilidades.AgregarComillas(dt.Chofer));
                parametros.Add("Cisterna1", Utilidades.AgregarComillas(dt.Cisterna1));
                parametros.Add("Cisterna2", Utilidades.AgregarComillas(dt.Cisterna2));
                parametros.Add("Cisterna3", Utilidades.AgregarComillas(dt.Cisterna3));
                parametros.Add("Cisterna4", Utilidades.AgregarComillas(dt.Cisterna4));
                parametros.Add("Cisterna5", Utilidades.AgregarComillas(dt.Cisterna5));
                parametros.Add("Cisterna6", Utilidades.AgregarComillas(dt.Cisterna6));
                parametros.Add("Motivo", Utilidades.AgregarComillas(dt.Motivo));
                parametros.Add("Comentarios", Utilidades.AgregarComillas(dt.Comentarios));
                if (Datos.DatosDB.Insertar("Precinto", parametros))
                {
                    Utilidades.MensajesOK("Registro generado con exito");

                    return true;
                }
                else
                {
                    Utilidades.MensajesAdvertencia("Error al generar el registro");
                    return false;
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
                return false;
            }

        }

        public static bool Modificar(Entidades.Precinto dt)
        {
            try
            {
                Dictionary<string, string> parametros = new Dictionary<string, string>();
                Dictionary<string, string> condicion = new Dictionary<string, string>();

                parametros.Add("Fecha", Utilidades.AgregarComillas(dt.Fecha));
                parametros.Add("Unidad", Utilidades.AgregarComillas(dt.Unidad));
                parametros.Add("Chofer", Utilidades.AgregarComillas(dt.Chofer));
                parametros.Add("Cisterna1", Utilidades.AgregarComillas(dt.Cisterna1));
                parametros.Add("Cisterna2", Utilidades.AgregarComillas(dt.Cisterna2));
                parametros.Add("Cisterna3", Utilidades.AgregarComillas(dt.Cisterna3));
                parametros.Add("Cisterna4", Utilidades.AgregarComillas(dt.Cisterna4));
                parametros.Add("Cisterna5", Utilidades.AgregarComillas(dt.Cisterna5));
                parametros.Add("Cisterna6", Utilidades.AgregarComillas(dt.Cisterna6));
                parametros.Add("Motivo", Utilidades.AgregarComillas(dt.Motivo));
                parametros.Add("Comentarios", Utilidades.AgregarComillas(dt.Comentarios));
                condicion.Add("Codigo", dt.Codigo.ToString());
                if (Datos.DatosDB.Actualizar("Precinto", parametros, condicion))
                {
                    Utilidades.MensajesOK("Registro modificado con exito");
                    return true;
                }
                else
                {
                    Utilidades.MensajesAdvertencia("Error al modificar registro");
                    return false;
                }
          
        }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al modificar registro");
                return false;
            }
        }

        public static bool Eliminar(Entidades.Precinto dt)
        {
            try
            {
                Dictionary<string, string> parametros = new Dictionary<string, string>();
                parametros.Add("Codigo", dt.Codigo.ToString());

                if (Datos.DatosDB.BajaLogica("Precinto", parametros))
                {
                    Utilidades.MensajesOK("Registro eliminado con exito");
                    return true;
                }
                else
                {
                    Utilidades.MensajesAdvertencia("Error al eliminar registro");
                    return false;
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
                return false;
            }
        }

        public static DataTable Listar()
        {
            try
            {
                Dictionary<string, string> parametros = new Dictionary<string, string>();
                parametros.Add("Baja", "False");
                return Datos.DatosDB.Listar("Precinto", parametros);
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al listar");
                return null;
            }

        }

        public static DataTable ListarFiltro(string filtro, string filtroUnidad)
        {
            try
            {
                string comando;
                comando = "Select * from Precinto Where Baja=False AND (Cisterna1 Like '%" + filtro + "%' " +
                    "OR Cisterna2 Like '%" + filtro + "%' " +
                    "OR Cisterna3 Like '%" + filtro + "%' " +
                    "OR Cisterna4 Like '%" + filtro + "%' " +
                    "OR Cisterna5 Like '%" + filtro + "%' " +
                    "OR Cisterna6 Like '%" + filtro + "%')" +
                    "AND Unidad Like '%" + filtroUnidad + "%'";

                return Datos.DatosDB.ListarComandoDirecto(comando);
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al listar");
                return null;
            }
        }

        //Reportes

        public static DataTable Reporte(int codigo)
        {
            try
            {
                string cadena = "select * from Precinto where Codigo =" + codigo.ToString();
                DataTable dt = Datos.DatosDB.ListarComandoDirecto(cadena);
                dt.TableName = "DataSet";
                return dt;
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al listar");
                return null;
            }
        }
    }
}
