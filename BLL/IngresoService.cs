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
    public class IngresoService
    {

        public static void Guardar(ingreso ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    db.ingresos.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception ex)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }

        }

        public static void Modificar(ingreso ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    ingreso ent_update = db.ingresos.Find(ent.id);
                    ent_update.descripcion = ent.descripcion;
                    ent_update.municipalidad_id = ent.municipalidad_id;
                    ent_update.importe = ent.importe;
                    ent_update.forma_pago = ent.forma_pago;
                    ent_update.fecha = ent.fecha;
                    ent_update.banco_id = ent.banco_id;
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro modificado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al modificar registro");
            }
        }

        public static void Eliminar(ingreso ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    ingreso ent_update = db.ingresos.Find(ent.id);
                    db.ingresos.Remove(ent_update);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }

        public static ingreso Obtener(int id)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    return db.ingresos.Find(id);
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error");
                return null;
            }
        }

        public static List<EntityIngreso> Listar()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityIngreso> lista = new List<EntityIngreso>();
                    foreach (var item in db.ingresos)
                    {
                        lista.Add(new EntityIngreso{ Id = item.id,Descripcion= item.descripcion, FormaPago = item.forma_pago,Municipalidad = item.municipalidad.nombre, Importe = item.importe,Fecha = item.fecha, Banco = item.banco.nombre});
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
