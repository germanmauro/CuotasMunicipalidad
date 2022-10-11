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
    public class BancoService
    {
        public static void Guardar(banco ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    db.bancos.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }

        }

        public static void Modificar(banco ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    banco ent_update = db.bancos.Find(ent.id);
                    ent_update.nombre = ent.nombre;
                    ent_update.direccion = ent.direccion;
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro modificado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al modificar registro");
            }
        }

        public static void Eliminar(banco ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    banco ent_update = db.bancos.Find(ent.id);
                    db.bancos.Remove(ent_update);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }

        public static List<EntityDireccion> Listar()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityDireccion> lista = new List<EntityDireccion>();
                    foreach (var item in db.bancos)
                    {
                        lista.Add(new EntityDireccion { Id = item.id, Nombre = item.nombre, Direccion = item.direccion });
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
