using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Model
{
    class Unit
    {
        [Key]
        public int UnitId { get; set; }
        [MaxLength(150)]
        public string UnitName { get; set; }

        public virtual ICollection<Item> Items { get; set; }

    }
}
