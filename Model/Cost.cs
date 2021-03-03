using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Model
{
    class Cost
    {

        [Key]
        public int CostId { get; set; }

        public float ItemCost { get; set; }

        [MaxLength(150)]
        public string Date { get; set; }

        public int ItemId { get; set; }

        public virtual Item Item { get; set; }

    }
}
