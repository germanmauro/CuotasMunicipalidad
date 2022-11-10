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
    public class PerfilService
    {
        public static void Guardar(perfil ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    db.perfiles.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }

        }

        public static void Modificar(perfil ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    perfil ent_update = db.perfiles.Find(ent.id);
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

        public static void Eliminar(perfil ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    perfil ent_update = db.perfiles.Find(ent.id);
                    db.perfiles.Remove(ent_update);
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
                    foreach (var item in db.perfiles)
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

        public static List<perfil> ListarCombo()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    return db.perfiles.ToList();
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
