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
            optionBuilder.UseSqlServer(@"workstation id=qts-simple-billing.mssql.somee.com; 
                                        packet size=4096;
                                        user id=quadrate_SQLLogin_1; 
                                        pwd=dv7p4lkpzl; 
                                        data source=qts-simple-billing.mssql.somee.com;
                                        persist security info=False;
                                        initial catalog=qts-simple-billing");
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Shelf> Shelves { get; set; }

        public DbSet<Unit> Units { get; set; }

        public DbSet<SellingPrice> SellingPrices { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
