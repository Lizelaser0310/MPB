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
    
    public partial class CajaMovimientoDetalle
    {
        public int Id { get; set; }
        public int CajaMovimientoId { get; set; }
        public int ConceptoPagoId { get; set; }
        public int ItemId { get; set; }
        public int Cantidad { get; set; }
        public decimal Descuento { get; set; }
        public decimal Importe { get; set; }
    
        public virtual ConceptoPago ConceptoPago { get; set; }
        public virtual CajaMovimiento CajaMovimiento { get; set; }
    }
}
