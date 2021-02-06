using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QTS_SimpleBilling.Model
{
    public class Employee
    {
        [Key]
        public int employee_id { get; set; }
        [MaxLength(60)]
        public string employee_name { get; set; }
        [MaxLength(25)]
        public string contact { get; set; }
        [MaxLength(40)]
        public string email { get; set; }
        [MaxLength(240)]
        public string address { get; set; }
        public int status { get; set; }
        [MaxLength(10)]
        public string employee_code { get; set; }
    }
}
