﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiAlquilerVehiculosql.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBALQUILERVEHICULOSEntities : DbContext
    {
        public DBALQUILERVEHICULOSEntities()
            : base("name=DBALQUILERVEHICULOSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AlquilerVehiculos> AlquilerVehiculos { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
    }
}
