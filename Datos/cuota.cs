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
    
    public partial class cuota
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cuota()
        {
            this.cuota_detalle = new HashSet<cuota_detalle>();
        }
    
        public int id { get; set; }
        public int municipalidad_id { get; set; }
        public Nullable<decimal> monto { get; set; }
        public Nullable<short> dia_vencimiento { get; set; }
        public Nullable<decimal> porcentaje_aumento_vencimiento { get; set; }
    
        public virtual municipalidad municipalidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cuota_detalle> cuota_detalle { get; set; }
    }
}