using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Model
{
    public class Shelf
    {
        [Key]
        public int ShelfId { get; set; }
        public string ShelfName { get; set; }
    }
}
