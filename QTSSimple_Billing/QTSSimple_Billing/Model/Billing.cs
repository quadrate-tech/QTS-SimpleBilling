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
            optionBuilder.UseSqlServer(@"Data Source=RI_FAN;Initial Catalog=Customer;Integrated Security=True");
        }
        public DbSet<Customer> CustomerTable { get; set; }
    }
}
