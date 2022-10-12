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
    public class GastoService
    {

        const int CANTIDAD_FOTOS = 3;
        public static void Guardar(gasto ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    db.gastos.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception ex)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }

        }

        public static void Modificar(gasto ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    gasto ent_update = db.gastos.Find(ent.id);
                    ent_update.descripcion = ent.descripcion;
                    ent_update.proveedor_id = ent.proveedor_id;
                    ent_update.importe = ent.importe;
                    ent_update.numero_factura = ent.numero_factura;
                    ent_update.forma_pago = ent.forma_pago;
                    ent_update.fecha = ent.fecha;
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro modificado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al modificar registro");
            }
        }

        public static void Eliminar(gasto ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    gasto ent_update = db.gastos.Find(ent.id);
                    db.gastos.Remove(ent_update);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }

        public static gasto Obtener(int id)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    return db.gastos.Find(id);
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error");
                return null;
            }
        }

        public static List<EntityGasto> Listar()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityGasto> lista = new List<EntityGasto>();
                    foreach (var item in db.gastos)
                    {
                        lista.Add(new EntityGasto{ Id = item.id,Descripcion= item.descripcion, FormaPago = item.forma_pago,Proveedor = item.proveedor.nombre, Importe = item.importe,Fecha = item.fecha, NumeroFactura = item.numero_factura});
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
