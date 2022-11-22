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
    public class CompraService
    {

        public static void Guardar(compra ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    db.compras.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception ex)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }

        }

        public static void Modificar(compra ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    compra ent_update = db.compras.Find(ent.id);
                    ent_update.descripcion = ent.descripcion;
                    ent_update.proveedor_id = ent.proveedor_id;
                    ent_update.importe = ent.importe;
                    ent_update.numero_factura = ent.numero_factura;
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

        public static void Eliminar(compra ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    compra ent_update = db.compras.Find(ent.id);
                    db.compras.Remove(ent_update);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }

        public static compra Obtener(int id)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    return db.compras.Find(id);
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error");
                return null;
            }
        }

        public static List<EntityCompra> Listar(string filtro = "")
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityCompra> lista = new List<EntityCompra>();
                    foreach (var item in db.compras.Where(c=> c.numero_factura.Contains(filtro) ||
                    c.proveedor.nombre.Contains(filtro) || c.descripcion.Contains(filtro)))
                    {
                        lista.Add(new EntityCompra{ Id = item.id,Descripcion= item.descripcion, FormaPago = item.forma_pago,Proveedor = item.proveedor.nombre, Importe = item.importe,Fecha = item.fecha, NumeroFactura = item.numero_factura, Banco = item.banco.nombre});
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

        public static List<EntityEgresosReporte> ReporteEgresos(int proveedor, int banco, string forma_pago, DateTime desde, DateTime hasta)
        {
            try
            {
                List<EntityEgresosReporte> list = new List<EntityEgresosReporte>();
                using (CuotasEntities db = new CuotasEntities())
                {
                    foreach (var ent_compra in db.compras.Where(c => c.fecha >= desde && c.fecha <= hasta && 
                    (proveedor == 0 ||  c.proveedor_id == proveedor)
                    && (banco == 0 || c.banco_id == banco) &&
                    (forma_pago == "Todas" || c.forma_pago == forma_pago)
                    
                    ))
                    {
                        EntityEgresosReporte ent_cuota = new EntityEgresosReporte
                        {
                            Descripcion = ent_compra.descripcion,
                            FormaPago = ent_compra.forma_pago,
                            Importe = ent_compra.importe,
                            Fecha = ent_compra.fecha,
                            Banco = ent_compra.banco.nombre,
                            Proveedor = ent_compra.proveedor.nombre
                        };
                        list.Add(ent_cuota);
                    }
                    return list;
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
