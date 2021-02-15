using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace QTS_SimpleBilling.Model
{
    public class Cost
    {
        [Key]
        [MaxLength(60)]
        public int CostId { get; set; }
        [MaxLength(60)]
        public double CostPrice { get; set; }
        [MaxLength(240)]
        public string ItemsCode { get; set; }
        [MaxLength(240)]
        public string Date { get; set; }
        
    }
}
