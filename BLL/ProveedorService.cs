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
    public class ProveedorService
    {
        public static void Guardar(proveedor ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    db.proveedores.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }

        }

        public static void Modificar(proveedor ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    proveedor ent_update = db.proveedores.Find(ent.id);
                    ent_update.nombre = ent.nombre;
                    ent_update.direccion = ent.direccion;
                    ent_update.cuit = ent.cuit;
                    ent_update.telefono = ent.telefono;
                    ent_update.mail= ent.mail;
                    ent_update.observaciones= ent.observaciones;
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro modificado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al modificar registro");
            }
        }

        public static void Eliminar(proveedor ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    proveedor ent_update = db.proveedores.Find(ent.id);
                    db.proveedores.Remove(ent_update);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }

        public static List<EntityProveedor> Listar()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityProveedor> lista = new List<EntityProveedor>();
                    foreach (var item in db.proveedores)
                    {
                        lista.Add(new EntityProveedor { Id = item.id, Nombre = item.nombre, Direccion = item.direccion,
                        CUIT = item.cuit, Email = item.mail, Telefono = item.telefono, Observaciones = item.observaciones});
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
