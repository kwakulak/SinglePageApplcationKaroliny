﻿using SinglePageApplicationKaroliny.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SinglePageApplicationKaroliny.DAL
{
    public class RecipiesContext : DbContext
    {

        public RecipiesContext()
            : base("RecipiesContext")
        {
        }

        public DbSet<Recipe> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
