﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QTS_SimpleBilling.Model
{
    internal class BillingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source = THELA; Initial Catalog = SB; Integrated Security = True");
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Shelf> Shelves { get; set; }

        public DbSet<Unit> Units { get; set; }

        public DbSet<SellingPrice> SellingPrices { get; set; }
        public DbSet<Cost> Costs { get; set; }


    }
}
