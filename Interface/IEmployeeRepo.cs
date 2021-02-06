using System;
using QTS_SimpleBilling.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QTS_SimpleBilling.Interface;

namespace QTS_SimpleBilling.Repo.EmployeeRepo
{
    internal interface IEmployeeRepo : CRUDInterface<Employee>
    {
    }
}
