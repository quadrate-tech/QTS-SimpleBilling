using Microsoft.EntityFrameworkCore;
using QTS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QTS
{
    public class ReciptBodyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-S4QLIS6\SQLEXPRESS_16_AT; database=Qts; Integrated Security=True");
        }

        public DbSet<ReceiptModel> receiptModels { get; set; }

    }
}
