using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace BLL
{
    public class OficinaService
    {
        public static void Guardar(oficina ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    db.oficinas.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }

        }

        public static void Modificar(oficina ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    oficina ent_update = db.oficinas.Find(ent.id);
                    ent_update.nombre = ent.nombre;
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro modificado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al modificar registro");
            }
        }

        public static void Eliminar(oficina ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    oficina ent_update = db.oficinas.Find(ent.id);
                    db.oficinas.Remove(ent_update);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception e)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }

        public static List<EntityBase> Listar()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityBase> lista = new List<EntityBase>();
                    foreach (var item in db.oficinas)
                    {
                        lista.Add(new EntityBase { Id = item.id, Nombre = item.nombre });
                    };
                    return lista;
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al listar");
                return null;
            }

        }

        public static List<oficina> ListarCombo()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    return db.oficinas.ToList();
                }
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
