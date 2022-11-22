using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class banco
    {
        public string Descripcion => $"{this.nombre} - {this.tipo_cuenta} - {this.numero_cuenta}";
    }
}
