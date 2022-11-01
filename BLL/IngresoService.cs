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

        public static List<EntityIngresosReporte> ReporteIngresos(int? municipalidad, DateTime? desde, DateTime? hasta)
        {
            try
            {
                List<EntityIngresosReporte> list = new List<EntityIngresosReporte>();
                using (CuotasEntities db = new CuotasEntities())
                {
                    foreach(var cuota_a_pagar in db.cuotas.Where(c=> (municipalidad == null || c.municipalidad_id == municipalidad) &&
                    (desde == null || c.fecha >= desde) && 
                    (hasta == null || c.fecha <= hasta)
                    )) 
                    {
                        EntityIngresosReporte ent_cuota = new EntityIngresosReporte
                        {
                            Descripcion = $"EMISIÓN {cuota_a_pagar.fecha.ToString("MMM - yyyy").ToUpper()}",
                          
                            Municipalidad = cuota_a_pagar.municipalidad.nombre,
                            Importe = cuota_a_pagar.importe + (cuota_a_pagar.estado == "Pagado" ? cuota_a_pagar.intereses: CuotaService.CalcularIntereses(cuota_a_pagar)),
                            Fecha = cuota_a_pagar.vencimiento
                        };
                        list.Add(ent_cuota);
                    }
                    foreach (var cuota_paga in db.cuotas.Where(c => (municipalidad == null || c.municipalidad_id == municipalidad) &&
                    (desde == null || c.fecha_pago >= desde) &&
                    (hasta == null || c.fecha_pago <= hasta) && c.estado == "Pagado"))
                    {
                        EntityIngresosReporte ent_cuota = new EntityIngresosReporte
                        {
                            Descripcion = $"PAGO {cuota_paga.fecha.ToString("MMM - yyyy").ToUpper()}",
                            FormaPago = cuota_paga.forma_pago,
                            Municipalidad = cuota_paga.municipalidad.nombre,
                            Importe = cuota_paga.importe_abonado*-1,
                            Fecha = cuota_paga.fecha_pago,
                            Banco = cuota_paga.banco.nombre
                        };
                        list.Add(ent_cuota);
                    }

                    foreach (var ent_ingreso in db.ingresos.Where(c => (municipalidad == null || c.municipalidad_id == municipalidad) &&
                    (desde == null || c.fecha >= desde) &&
                    (hasta == null || c.fecha <= hasta)
                    ))
                    {
                        EntityIngresosReporte ent_cuota = new EntityIngresosReporte
                        {
                            Descripcion = ent_ingreso.descripcion,
                            FormaPago = ent_ingreso.forma_pago,
                            Municipalidad = ent_ingreso.municipalidad.nombre,
                            Importe = ent_ingreso.importe*-1,
                            Fecha = ent_ingreso.fecha,
                            Banco = ent_ingreso.banco.nombre
                        };
                        list.Add(ent_cuota);
                    }
                    return list.OrderBy(c=>c.Fecha).ToList();
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
