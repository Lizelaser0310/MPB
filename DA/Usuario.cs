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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.CajaDiario = new HashSet<CajaDiario>();
        }
    
        public int Id { get; set; }
        public Nullable<int> RolId { get; set; }
        public int PersonalId { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Activo { get; set; }
        public bool IndCambio { get; set; }
        public bool IndUso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CajaDiario> CajaDiario { get; set; }
        public virtual Personal Personal { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
