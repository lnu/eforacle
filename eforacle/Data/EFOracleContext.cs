// <copyright file="EFOracleContext.cs" company="Translation Centre for the Bodies of the European Union">
//  Copyright (c) 2013 All Rights Reserved
// </copyright>

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using EFOracle.Model;

namespace EFOracle.Data
{
    public class EFOracleContext : DbContext
    {
        public DbSet<Region> Region { get; set; }

        public DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            modelBuilder.Entity<Region>().ToTable("REGIONS", "DEMO");
            modelBuilder.Entity<Region>().Property(p => p.id).HasColumnName("ID").IsRequired();
            modelBuilder.Entity<Region>().Property(p => p.Name).HasColumnName("NAME").IsRequired();
            modelBuilder.Entity<Region>().HasMany(p => p.Countries).WithRequired(i=>i.Region).Map(p=>p.MapKey("REGION_ID"));
            modelBuilder.Entity<Region>().HasKey(p => p.id);

            modelBuilder.Entity<Country>().ToTable("COUNTRIES", "DEMO");
            modelBuilder.Entity<Country>().Property(p => p.id).HasColumnName("ID").IsRequired();
            modelBuilder.Entity<Country>().Property(p => p.Name).HasColumnName("NAME").IsRequired();
            modelBuilder.Entity<Country>().HasKey(p => p.id);
        }
    }
}