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
    
    public partial class TipoComprobante
    {
        public int Id { get; set; }
        public int CajaId { get; set; }
        public string Descripcion { get; set; }
        public string Serie { get; set; }
        public bool Estado { get; set; }
    
        public virtual Caja Caja { get; set; }
    }
}
