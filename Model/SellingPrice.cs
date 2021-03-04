using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Model
{
    public class SellingPrice
    {
        public int PriceId { get; set; }
        public float Price { get; set; }
        public int ItemCode { get; set; }
        public DateTime Date { get; set; }
    }
}
