using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Model
{
    class ReceiptBody
    {
        public int ReceiptNo { get; set; }
        
        public string ProductCode { get; set; }
        
        public string UnitPrice { get; set; }
        
        public string Quantity { get; set; }
        
        public string Discount { get; set; }
        
        public string SubTotal { get; set; }
        
        public string NetTotal { get; set; }
        
    }
}
