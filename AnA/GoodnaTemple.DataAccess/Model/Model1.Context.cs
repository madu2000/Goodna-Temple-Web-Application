﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoodnaTemple.DataAccess.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Goodna_TempleEntities : DbContext
    {
        public Goodna_TempleEntities()
            : base("name=Goodna_TempleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<M2000_WP_GOODNA_USER_ACCOUNTS> M2000_WP_GOODNA_USER_ACCOUNTS { get; set; }
    }
}
