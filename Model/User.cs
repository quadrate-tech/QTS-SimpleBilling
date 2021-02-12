using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Model
{
    class User
    {
        [Key]
        public int UserID { get; set; }
        [MaxLength(60)]

        public String UserName { get; set; }
        [MaxLength(60)]

        public String Password { get; set; }
        [MaxLength(60)]

        public String UserType { get; set; }
        [MaxLength(60)]

        public int EmployeeID  { get; set; }
    }
}
