//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class compra
    {
        public int id { get; set; }
        public int proveedor_id { get; set; }
        public int banco_id { get; set; }
        public Nullable<decimal> importe { get; set; }
        public string numero_factura { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string descripcion { get; set; }
        public string forma_pago { get; set; }
    
        public virtual banco banco { get; set; }
        public virtual proveedor proveedor { get; set; }
    }
}
