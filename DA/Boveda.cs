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
    
    public partial class Boveda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boveda()
        {
            this.BovedaMovimiento = new HashSet<BovedaMovimiento>();
        }
    
        public int Id { get; set; }
        public decimal SaldoInicial { get; set; }
        public Nullable<decimal> Entradas { get; set; }
        public Nullable<decimal> SaldoFinal { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public bool IndCierre { get; set; }
        public Nullable<decimal> Salidas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BovedaMovimiento> BovedaMovimiento { get; set; }
    }
}
