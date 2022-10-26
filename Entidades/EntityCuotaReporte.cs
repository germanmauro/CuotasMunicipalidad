using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntityCuotaReporte
    {
        public int Id { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImporteAbonado { get; set; }
        public decimal? Total {
            get
            {
                return this.Importe + this.Intereses;
            }
        }
        public string Cuota {
            get
            {
                return this.Fecha.ToString("MMM - yyyy").ToUpper();
            }
        }
        public string NumeroLetras {get; set;}
        public string Recibo {
            get 
            {
                return this.Id.ToString().PadLeft(8,'0');
            }
        }
        public decimal? Intereses { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? Vencimiento { get; set; }
        public DateTime? FechaPago { get; set; }
        public  string Municipalidad { get; set; }
        public  string Banco { get; set; }
        public string EstadoCuota { get; set; }
        public string FormaPago { get; set; }

        public EntityCuotaReporte()
        {
        }
    }
}
