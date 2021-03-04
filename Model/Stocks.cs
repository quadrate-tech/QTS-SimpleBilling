using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Model
{
    public class Stocks
    {
        [Key]
        public int StockId { get; set; }
        public int ItemCode { get; set; }

        public int StockQty { get; set; }
        public DateTime StockDate { get; set; }

    }
}
