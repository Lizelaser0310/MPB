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
    
    public partial class Matricula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matricula()
        {
            this.CuentasPorCobrar = new HashSet<CuentasPorCobrar>();
            this.MatriculaDetalle = new HashSet<MatriculaDetalle>();
        }
    
        public int Id { get; set; }
        public int CondicionEstudioId { get; set; }
        public int AlumnoId { get; set; }
        public int PeridoId { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public bool IndPagoMatricula { get; set; }
        public bool IndPagoUnico { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> EspecialidadId { get; set; }
        public string Proceso { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        public virtual CondicionEstudio CondicionEstudio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasPorCobrar> CuentasPorCobrar { get; set; }
        public virtual Periodo Periodo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatriculaDetalle> MatriculaDetalle { get; set; }
    }
}
