using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntityInventario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Oficina { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string MotivoBaja { get; set; }
        public string Estado { get; set; }

        public EntityInventario()
        {
        }
    }
}
