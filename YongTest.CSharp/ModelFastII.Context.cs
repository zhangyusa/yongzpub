﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YongTest.CSharp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FastIIEntities : DbContext
    {
        public FastIIEntities()
            : base("name=FastIIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ArHeader> ArHeaders { get; set; }
        public virtual DbSet<ArHeaderExtend> ArHeaderExtends { get; set; }
        public virtual DbSet<ArHeaderExtraInfo> ArHeaderExtraInfoes { get; set; }
        public virtual DbSet<ArMastfl> ArMastfls { get; set; }
        public virtual DbSet<ContractsDetail> ContractsDetails { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
