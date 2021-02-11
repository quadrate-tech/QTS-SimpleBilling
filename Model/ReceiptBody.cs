using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QTS_SimpleBilling.Model
{
   public class ReceiptBody
    {
        [Key]
        public int ReceiptNo { get; set; }
        [MaxLength(40)]
        public string ProductCode { get; set; }
        [MaxLength(25)]
        public string UnitPrice { get; set; }
        [MaxLength(25)]
        public string Quantity { get; set; }
        [MaxLength(25)]
        public string Discount { get; set; }
        [MaxLength(25)]
        public string SubTotal { get; set; }
        [MaxLength(25)]
        public string NetTotal { get; set; }
       
    }
}
