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
    public class InventarioService
    {

        const int CANTIDAD_FOTOS = 3;
        public static void Guardar(inventario ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    ent.fecha = DateTime.Today;
                    db.inventarios.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception ex)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }

        }

        public static void Modificar(inventario ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    inventario ent_update = db.inventarios.Find(ent.id);
                    ent_update.nombre = ent.nombre;
                    ent_update.oficina = ent.oficina;
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro modificado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al modificar registro");
            }
        }
        public static void Baja(inventario ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    inventario ent_update = db.inventarios.Find(ent.id);
                    ent_update.motivo_baja = ent.motivo_baja;
                    ent_update.baja = true;
                    ent_update.fecha_baja = DateTime.Now;
                    db.SaveChanges();
                    Utilidades.MensajesOK("Baja de invertario realizada con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al modificar registro");
            }
        }

        public static inventario Obtener(int id)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    return db.inventarios.Find(id);
    
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error");
                return null;
            }
        }

        public static void Eliminar(inventario ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    inventario ent_update = db.inventarios.Find(ent.id);
                    db.inventarios.Remove(ent_update);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }
        public static void EliminarBaja(inventario ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    inventario ent_update = db.inventarios.Find(ent.id);
                    ent_update.motivo_baja = "";
                    ent_update.fecha_baja = null;
                    db.SaveChanges();
                    Utilidades.MensajesOK("Baja eliminada con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }

        public static List<EntityInventario> Listar(string filtro = "")
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityInventario> lista = new List<EntityInventario>();
                    foreach (var item in db.inventarios.Where(c=> c.nombre.Contains(filtro) || c.oficina.nombre.Contains(filtro)))
                    {
                        lista.Add(new EntityInventario { Id = item.id,Nombre = item.nombre, Oficina = item.oficina.nombre, Fecha = item.fecha, FechaBaja = item.fecha_baja??DateTime.MinValue, MotivoBaja = item.motivo_baja, Estado = item.baja == null ? "Activo": "Baja" });
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
        public static List<EntityInventario> ListarBajas()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityInventario> lista = new List<EntityInventario>();
                    foreach (var item in db.inventarios)
                    {
                        lista.Add(new EntityInventario { Id = item.id,Nombre = item.nombre, Oficina = item.oficina.nombre, Fecha = item.fecha, FechaBaja = item.fecha_baja, MotivoBaja = item.motivo_baja});
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
                    return inventario.inventario_foto.Count() < CANTIDAD_FOTOS;
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
