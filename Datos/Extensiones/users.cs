using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class user
    {
        public string Descripcion => this.nombre + " " + this.apellido + "(" + this.usuario + ")";
    }
}
