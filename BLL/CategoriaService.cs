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
    public class CategoriaService
    {
        public static void Guardar(categoria ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    db.categorias.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }

        }

        public static void Modificar(categoria ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    categoria ent_update = db.categorias.Find(ent.id);
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

        public static void Eliminar(categoria ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    categoria ent_update = db.categorias.Find(ent.id);
                    db.categorias.Remove(ent_update);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception)
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
                    foreach (var item in db.categorias)
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

      
    }
}
