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
    public class MunicipalidadService
    {
        public static void Guardar(municipalidad ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    db.municipalidades.Add(ent);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro generado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al generar registro");
            }

        }

        public static void Modificar(municipalidad ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    municipalidad ent_update = db.municipalidades.Find(ent.id);
                    ent_update.nombre = ent.nombre;
                    ent_update.direccion = ent.direccion;
                    ent_update.cuit = ent.cuit;
                    ent_update.telefono = ent.telefono;
                    ent_update.mail= ent.mail;
                    ent_update.condicion_iva = ent.condicion_iva;
                    ent_update.monto = ent.monto;
                    ent_update.dia_vencimiento = ent.dia_vencimiento;
                    ent_update.porcentaje_aumento_vencimiento = ent.porcentaje_aumento_vencimiento;

                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro modificado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al modificar registro");
            }
        }

        public static void Eliminar(municipalidad ent)
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    municipalidad ent_update = db.municipalidades.Find(ent.id);
                    db.municipalidades.Remove(ent_update);
                    db.SaveChanges();
                    Utilidades.MensajesOK("Registro eliminado con exito");
                }
            }
            catch (Exception)
            {
                Utilidades.MensajesAdvertencia("Error al eliminar registro");
            }
        }

        public static List<EntityMunicipalidad> Listar()
        {
            try
            {
                using (CuotasEntities db = new CuotasEntities())
                {
                    List<EntityMunicipalidad> lista = new List<EntityMunicipalidad>();
                    foreach (var item in db.municipalidades)
                    {
                        lista.Add(new EntityMunicipalidad { Id = item.id, Nombre = item.nombre, Direccion = item.direccion,
                        CUIT = item.cuit, Email = item.mail, Telefono = item.telefono, Condicion = item.condicion_iva,
                        DiaVencimiento = item.dia_vencimiento, MontoCuota = item.monto, PorcentajeAumento = item.porcentaje_aumento_vencimiento});
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
