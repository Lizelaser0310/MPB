//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConceptoPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConceptoPago()
        {
            this.CajaMovimientoDetalle = new HashSet<CajaMovimientoDetalle>();
            this.CuentasPorCobrarDetalle = new HashSet<CuentasPorCobrarDetalle>();
        }
    
        public int Id { get; set; }
        public int Item { get; set; }
        public string Concepto { get; set; }
        public Nullable<decimal> Precio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CajaMovimientoDetalle> CajaMovimientoDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasPorCobrarDetalle> CuentasPorCobrarDetalle { get; set; }
    }
}