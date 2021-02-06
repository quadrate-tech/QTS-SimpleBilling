using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QTS_SimpleBilling.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [MaxLength(60)]
        public string EmployeeName { get; set; }
        [MaxLength(25)]
        public string Contact { get; set; }
        [MaxLength(40)]
        public string Email { get; set; }
        [MaxLength(240)]
        public string Address { get; set; }
        public int Status { get; set; }
        [MaxLength(10)]
        public string EmployeeCode { get; set; }
    }
}
