﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Model
{
    class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(150)]
        public string CategoryName { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
