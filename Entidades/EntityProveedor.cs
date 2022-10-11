using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntityProveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }

        public EntityProveedor()
        {
        }
    }
}
