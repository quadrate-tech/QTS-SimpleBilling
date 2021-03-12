using System.ComponentModel.DataAnnotations;

namespace QTS_SimpleBilling.Model
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public Category ItemCategory { get; set; }
        public Unit ItemUnit { get; set; }
        public string Barcode { get; set; }
        public Shelf Shelf { get; set; }
        public bool IsService { get; set; }

    }
}
