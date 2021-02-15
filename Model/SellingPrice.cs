using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QTS_SimpleBilling.Model
{
   public class SellingPrice
    {

        [Key]
        [MaxLength(60)]
        public int PricId { get; set; }
        [MaxLength(60)]
        public double Price { get; set; }
        [MaxLength(240)]
        public string ItemsCode { get; set; }
        [MaxLength(240)]
        public string Date { get; set; }

       
    }
}
