using System;
using QTS_SimpleBilling.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Repo.Employee
{
    internal interface IEmployeeRepo
    {
        Employee Create(Employee emp)
    }
}
