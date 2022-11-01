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
    public class CuotaService
    {

        public static void Guardar(cuota ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    ent.importe_abonado = 0;
                    ent.estado = "A pagar";
                    ent.intereses = 0;
                    ent.municipalidad_id = ent.municipalidad.id;
                    ent.vencimiento = CalcularVencimiento(ent.fecha, ent.municipalidad.dia_vencimiento);
                    ent.municipalidad = null;
                    db.cuotas.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception ex)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }
        }
        public static void Pagar(cuota ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    cuota ent_update = db.cuotas.Find(ent.id);
                    ent_update.estado = "Pagado";
                    ent_update.intereses = CalcularIntereses(ent_update);
                    ent_update.importe_abonado = ent.importe_abonado;
                    ent_update.forma_pago = ent.forma_pago;
                    ent_update.fecha_pago = ent.fecha_pago;
                    ent_update.banco_id = ent.banco_id;
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro de pago correcto");
                }
            }
            catch (Exception ex)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }
        }

        public static void Modificar(cuota ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    cuota ent_update = db.cuotas.Find(ent.id);
                    ent_update.estado = ent.estado;
                    ent_update.municipalidad_id = ent.municipalidad_id;
                    ent_update.importe = ent.importe;
                    ent_update.importe_abonado = ent.importe_abonado;
                    ent_update.forma_pago = ent.forma_pago;
                    ent_update.fecha = ent.fecha;
                    ent_update.fecha_pago = ent.fecha_pago;
                    ent_update.banco_id = ent.banco_id;
                    ent_update.vencimiento = ent.vencimiento;
                    ent_update.intereses = ent.intereses;
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro modificado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al modificar registro");
            }
        }

        public static void Eliminar(cuota ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    cuota ent_update = db.cuotas.Find(ent.id);
                    db.cuotas.Remove(ent_update);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }
        public static void EliminarPago(cuota ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    cuota ent_update = db.cuotas.Find(ent.id);

                    ent_update.estado = "A pagar";
                    ent_update.importe_abonado = 0;
                    ent_update.forma_pago = ent.forma_pago;
                    ent_update.fecha_pago = null;
                    ent_update.banco_id = null;
                    ent_update.intereses = 0;

                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }

        public static cuota Obtener(int id)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    return db.cuotas.Find(id);
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error");
                return null;
            }
        }

        public static List<EntityCuota> Listar(int municipalidad)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityCuota> lista = new List<EntityCuota>();
                    foreach (var item in db.cuotas.Where(c=> c.municipalidad_id == municipalidad).OrderBy(c=> c.fecha))
                    {
                        lista.Add(new EntityCuota
                        { 
                            Id = item.id,
                            EstadoCuota = item.estado,
                            FormaPago = item.forma_pago,
                            Municipalidad = item.municipalidad.nombre,
                            Importe = item.importe,
                            ImporteAbonado = item.importe_abonado,
                            Fecha = item.fecha.ToString("MMM - yyyy"),
                            Banco = item.banco != null ? item.banco.nombre : "",
                            FechaPago = item.fecha_pago,
                            Intereses = item.intereses,
                            Vencimiento = item.vencimiento
                        });
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
        public static List<EntityCuota> ListarAPagar()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityCuota> lista = new List<EntityCuota>();
                    foreach (var item in db.cuotas.Where(c=> c.estado == "A pagar").OrderBy(c => c.fecha))
                    {
                        lista.Add(new EntityCuota
                        { 
                            Id = item.id,
                            EstadoCuota = item.estado,
                            FormaPago = item.forma_pago,
                            Municipalidad = item.municipalidad.nombre,
                            Importe = item.importe,
                            ImporteAbonado = item.importe_abonado,
                            Fecha = item.fecha.ToString("MMM - yyyy"),
                            Banco = item.banco != null ? item.banco.nombre : "",
                            FechaPago = item.fecha_pago,
                            Intereses = CalcularIntereses(item),
                            Vencimiento = item.vencimiento
                        });
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

        public static List<EntityCuota> ListarPagas()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityCuota> lista = new List<EntityCuota>();
                    foreach (var item in db.cuotas.Where(c => c.estado == "Pagado").OrderBy(c => c.fecha))
                    {
                        lista.Add(new EntityCuota
                        {
                            Id = item.id,
                            EstadoCuota = item.estado,
                            FormaPago = item.forma_pago,
                            Municipalidad = item.municipalidad.nombre,
                            Importe = item.importe,
                            ImporteAbonado = item.importe_abonado,
                            Fecha = item.fecha.ToString("MMM - yyyy"),
                            Banco = item.banco != null ? item.banco.nombre : "",
                            FechaPago = item.fecha_pago,
                            Intereses = item.intereses,
                            Vencimiento = item.vencimiento
                        });
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
        public static DateTime CalcularVencimiento(DateTime fecha, short? dia)
        {
            int restarDia = 0;
            DateTime fecha_vencimiento;
            while(!DateTime.TryParse(fecha.ToString("yyyy-MM") + "-" + (dia - restarDia).ToString().PadLeft(2, '0'),out fecha_vencimiento));
            {
                restarDia++;
            }

            return fecha_vencimiento;
        }

        public static bool VerificarCuotasCreada(cuota ent)
        {
            using (CuotasEntities db = new CuotasEntities())
            {
                int cantidad = db.cuotas.Where(c => c.fecha.Year == ent.fecha.Year 
                && c.fecha.Month == ent.fecha.Month && c.municipalidad_id == ent.municipalidad.id).Count();
                if(cantidad > 0)
                {
                    Utilidades.MensajesAdvertencia("Ya existe un cuota para ese mes");
                    return true;
                }
                return false;
            }
        }

        public static decimal CalcularIntereses(cuota ent)
        {
            DateTime fecha_actual = DateTime.Today;
            DateTime fecha_vencimiento = ent.vencimiento??DateTime.Today;
            decimal porcentaje_aumento = ((ent.municipalidad.porcentaje_aumento_vencimiento ?? 0) /100) + 1;
            double dias_diferencia = (fecha_actual - fecha_vencimiento).TotalDays/7;
            decimal interes = 0;
            decimal porcentaje_interes = 1;
            for (int i = 0; i < dias_diferencia; i++)
            {
                porcentaje_interes *= porcentaje_aumento;
            }
            porcentaje_interes = porcentaje_interes > 0 ? porcentaje_interes -1 : 0;

            interes = (ent.importe ?? 0) * porcentaje_interes;

            return Math.Round(interes,2);
        }

        #region "Reportes"
        public static List<EntityCuotaReporte> ReporteVolante(int cuota)
        {
            try
            {
                List<EntityCuotaReporte> list = new List<EntityCuotaReporte>();
                using (CuotasEntities db = new CuotasEntities())
                {
                    cuota item = db.cuotas.Find(cuota);
                    EntityCuotaReporte ent_cuota =  new EntityCuotaReporte
                    {
                        Id = item.id,
                        EstadoCuota = item.estado,
                        FormaPago = item.forma_pago,
                        Municipalidad = item.municipalidad.nombre,
                        Importe = item.importe,
                        Fecha = item.fecha,
                        Intereses = CalcularIntereses(item),
                        Vencimiento = item.vencimiento
                    };
                    list.Add(ent_cuota);
                    return list;
                }
                
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al listar");
                return null;
            }
        }
        
        public static List<EntityCuotaReporte> ReporteRecibo(int cuota)
        {
            try
            {
                List<EntityCuotaReporte> list = new List<EntityCuotaReporte>();
                using (CuotasEntities db = new CuotasEntities())
                {
                    cuota item = db.cuotas.Find(cuota);
                    EntityCuotaReporte ent_cuota = new EntityCuotaReporte
                    {
                        Id = item.id,
                        EstadoCuota = item.estado,
                        FormaPago = item.forma_pago,
                        NumeroLetras = (item.importe_abonado ?? 0m).NumeroALetras(),
                        Municipalidad = item.municipalidad.nombre,
                        Importe = item.importe,
                        ImporteAbonado = item.importe_abonado,
                        Banco = item.banco.nombre,
                        Fecha = item.fecha,
                        FechaPago = item.fecha_pago,
                        Intereses = item.intereses,
                        Vencimiento = item.vencimiento
                    };
                    list.Add(ent_cuota);
                    return list;
                }
                
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al listar");
                return null;
            }
        }
        #endregion
    }
}
