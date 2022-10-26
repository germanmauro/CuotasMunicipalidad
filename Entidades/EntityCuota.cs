using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntityCuota
    {
        public int Id { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImporteAbonado { get; set; }
        public decimal? Intereses { get; set; }
        public string Fecha { get; set; }
        public DateTime? Vencimiento { get; set; }
        public DateTime? FechaPago { get; set; }
        public  string Municipalidad { get; set; }
        public  string Banco { get; set; }
        public string EstadoCuota { get; set; }
        public string FormaPago { get; set; }

        public EntityCuota()
        {
        }
    }
}
