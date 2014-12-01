﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Find3dPrinting.Data.EF
{
    using System;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Find3dPrinting.Models;

    public partial class Find3dPrintingContext : DbContext
    {
        public Find3dPrintingContext()
            : base("name=Find3dPrintingEntities")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<BoxSize> BoxSizes { get; set; }
        public DbSet<ComputeTechnology> ComputeTechnologies { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Delivery_Manufacturers> Delivery_Manufacturers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Manufacturers_Printers> Manufacturers_Printers { get; set; }
        public DbSet<Manufacturers_Services> Manufacturers_Services { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Payments_Manufacturers> Payments_Manufacturers { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
    }
}