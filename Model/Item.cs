using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Model
{
    class Item
    {
        [Key]
        public int ItemId { get; set; }

        [MaxLength(150)]
        public string ItemCode { get; set; }

        [MaxLength(150)]
        public string ItemName { get; set; }

        [MaxLength(150)]
        public string ItemBarcode { get; set; }

        public bool IsService { get; set; }

        public virtual Category Category { get; set; }
        public virtual Shelf Shelf { get; set; }
        public virtual Unit Unit { get; set; }

        public virtual SellingPrice SellingPrice { get; set; }

        public virtual Cost Cost { get; set; }
    }
}
