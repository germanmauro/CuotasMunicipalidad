using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntityIngresosReporte
    {
        public int Id { get; set; }
        public decimal? Importe { get; set; }
        public DateTime? Fecha {get; set;}
        public  string Municipalidad { get; set; }
        public  string Banco { get; set; }
        public string FormaPago { get; set; }
        public string Descripcion { get; set; }

        public EntityIngresosReporte()
        {
        }
    }
}
