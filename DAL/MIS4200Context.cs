﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gb538515Mis4200.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object

namespace gb538515Mis4200.DAL
{
    public class MIS4200Context : DbContext // inherits from DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,
gb538515Mis4200.Migrations.MISContext.Configuration>("DefaultConnection"));
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<petDetail> petDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}