using System.ComponentModel.DataAnnotations;

namespace QTS_SimpleBilling.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [MaxLength(60)]
        public string CustomerName { get; set; }
        [MaxLength(25)]
        public string Contact { get; set; }
        [MaxLength(40)]
        public string Email { get; set; }
        [MaxLength(240)]
        public string Address { get; set; }
    }
}
