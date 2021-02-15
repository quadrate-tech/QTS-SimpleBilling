using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;



namespace QTS_SimpleBilling.Model
{
        internal class BillingContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            {
                optionBuilder.UseSqlServer(@"Data Source=DESKTOP-HGKFMEC\SQLEXPRESS;database=QTSbilling;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }

            public DbSet<Catagory> catagories { get; set; }
            public DbSet<Cost> costs { get; set; }
            public DbSet<Items> itemes { get; set; }
            public DbSet<Shelf> shelves { get; set; }
            public DbSet<Unit> units { get; set; }
            public DbSet<SellingPrice> sellingPrices { get; set; }
        public object Catagory { get; internal set; }
    }
    }

