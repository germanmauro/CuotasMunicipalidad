using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;
using System.Security.Cryptography;

namespace BLL
{
    public class UsuarioService
    {
        public static void Guardar(user ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    ent.password = Utilidades.Encrypt(ent.password);
                    db.users.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }

        }

        public static void Modificar(user ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    user ent_update = db.users.Find(ent.id);
                    ent_update.nombre = ent.nombre;
                    ent_update.apellido = ent.apellido;
                    ent_update.usuario = ent.usuario;
                    ent_update.password = Utilidades.Encrypt(ent.password);
                    ent_update.perfil_id = ent.perfil_id;
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro modificado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al modificar registro");
            }
        }

        public static void CambiarPassword(string pass)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    user ent_update = db.users.Find(Session.GetInstance().usuario.id);
                    ent_update.password = Utilidades.Encrypt(pass);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro modificado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al modificar registro");
            }
        }

        public static void Eliminar(user ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    user ent_update = db.users.Find(ent.id);
                    db.users.Remove(ent_update);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }

        public static List<EntityUsers> Listar()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityUsers> lista = new List<EntityUsers>();
                    foreach (var item in db.users)
                    {
                        lista.Add(new EntityUsers { Id = item.id, Nombre = item.nombre, Apellido = item.apellido, Perfil = item.perfil.nombre, Usuario = item.usuario});
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
