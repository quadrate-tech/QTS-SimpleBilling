using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QTS.Model
{
    public class ReceiptModel
    {
        [Key]
        public int ProductCode { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name ="Recipt Number")]
        public string ReciptNo { get; set; }
        [Required]
        public string UnitPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float Discount { get; set; }
        [Required]
        public float Subtotal { get; set; }
        [Required]
        public float NetTotaal { get; set; }
        
    }
}
