﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DAEntities : DbContext
    {
        public DAEntities()
            : base("name=DAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumno_Especialidad> Alumno_Especialidad { get; set; }
        public virtual DbSet<Aula> Aula { get; set; }
        public virtual DbSet<Boveda> Boveda { get; set; }
        public virtual DbSet<CajaDiario> CajaDiario { get; set; }
        public virtual DbSet<CondicionEstudio> CondicionEstudio { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Notas> Notas { get; set; }
        public virtual DbSet<Operacion> Operacion { get; set; }
        public virtual DbSet<Periodo> Periodo { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Personal_Tipo> Personal_Tipo { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<TipoPersonal> TipoPersonal { get; set; }
        public virtual DbSet<ValorTabla> ValorTabla { get; set; }
        public virtual DbSet<ConceptoPago> ConceptoPago { get; set; }
        public virtual DbSet<BovedaMovimiento> BovedaMovimiento { get; set; }
        public virtual DbSet<CajaMovimientoDetalle> CajaMovimientoDetalle { get; set; }
        public virtual DbSet<Caja> Caja { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<PermisoDenegadoRol> PermisoDenegadoRol { get; set; }
        public virtual DbSet<CuentasPorCobrar> CuentasPorCobrar { get; set; }
        public virtual DbSet<CuentasPorCobrarDetalle> CuentasPorCobrarDetalle { get; set; }
        public virtual DbSet<MatriculaDetalle> MatriculaDetalle { get; set; }
        public virtual DbSet<TipoComprobante> TipoComprobante { get; set; }
        public virtual DbSet<CajaMovimiento> CajaMovimiento { get; set; }
        public virtual DbSet<Matricula> Matricula { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
    }
}
