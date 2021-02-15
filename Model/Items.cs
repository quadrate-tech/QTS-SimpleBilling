using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QTS_SimpleBilling.Model
{
    public class Items
    {
        [Key]
        [MaxLength(60)]
        public int ItemsId { get; set; }
        [MaxLength(240)]
        public string ItemsName { get; set; }
        [MaxLength(25)]
        public string ItemsCatagory { get; set; }
        [MaxLength(40)]
        public string ItemsUnit { get; set; }
        [MaxLength(240)]
        public string ItemsBarcode { get; set; }
        [MaxLength(40)]
        public string Shelf { get; set; }
        [MaxLength(240)]
        public string IsService { get; set; }
       

    }
}
