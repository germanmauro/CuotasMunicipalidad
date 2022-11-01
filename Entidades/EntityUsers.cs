using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntityUsers
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Perfil { get; set; }
        public string Usuario { get; set; }

        public EntityUsers()
        {
        }
    }
}
