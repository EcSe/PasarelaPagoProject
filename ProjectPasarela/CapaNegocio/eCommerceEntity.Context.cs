﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaNegocio
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDEcommerceEntities : DbContext
    {
        public BDEcommerceEntities()
            : base("name=BDEcommerceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TClientePasarela> TClientePasarela { get; set; }
        public virtual DbSet<TCuentaAhorroPasarela> TCuentaAhorroPasarela { get; set; }
        public virtual DbSet<TMovimientoPasarela> TMovimientoPasarela { get; set; }
        public virtual DbSet<TTarjetaPasarela> TTarjetaPasarela { get; set; }
    }
}