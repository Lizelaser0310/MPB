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
    
    public partial class Alumno_Especialidad
    {
        public int Id { get; set; }
        public int EspecialidadId { get; set; }
        public int AlumnoId { get; set; }
    
        public virtual Especialidad Especialidad { get; set; }
        public virtual Alumno Alumno { get; set; }
    }
}