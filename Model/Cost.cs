using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Model
{
    public class Cost
    {
        [Key]
        public int CostID { get; set; }
        public float ItemCost { get; set; }
        public int ItemCode { get; set; }
        public DateTime Date { get; set; }

    }
}
