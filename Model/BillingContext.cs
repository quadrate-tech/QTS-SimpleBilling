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
            optionBuilder.UseSqlServer(@"Data Source=DESKTOP-BEJH8GV;database=CustomerDb;Initial Catalog=QTS_SimpleBillingSystem;Integrated Security=True");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
