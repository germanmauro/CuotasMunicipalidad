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
    public class InventarioFotoService
    {

        const int CANTIDAD_FOTOS = 3;
        public static void Guardar(inventario_foto ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    db.inventario_foto.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception ex)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }

        }

        public static void Eliminar(inventario_foto ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    inventario_foto ent_update = db.inventario_foto.Find(ent.id);
                    db.inventario_foto.Remove(ent_update);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }

        public static inventario_foto Obtener(int id)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    return db.inventario_foto.Find(id);
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error");
                return null;
            }
        }

        public static List<EntityBase> Listar()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityBase> lista = new List<EntityBase>();
                    foreach (var item in db.inventario_foto)
                    {
                        lista.Add(new EntityBase{ Id = item.id,Nombre = item.foto});
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

        public static bool cantidadFotos(int id)
        {
            try
            {
               
                using (CuotasEntities db = new CuotasEntities())
                {
                    var inventario = db.inventarios.Find(id);
                    return inventario.inventario_foto.Count() <= CANTIDAD_FOTOS;
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al listar");
                return false;
            }
            
        }
    }
}
