using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Model;
using QTS_SimpleBilling.Repo.EmployeeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTS_SimpleBilling.EmpRepo
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public int Create(Employee t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                var emp = context.Employees.FirstOrDefault(c => c.EmployeeId == t.EmployeeId);
                if (emp == null)
                {
                    context.Add(t);
                    return result = context.SaveChanges();
                }
                else
                {
                    using BillingContext con = new BillingContext();
                    con.Update(t);
                    return result = con.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result = 0;
            }
        }

        public int Delete(Employee t)
        {
            throw new NotImplementedException();
        }

        public int Update(Employee t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.Update(t);
                return result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result;
            }
        }

        public List<Employee> View()
        {
            throw new NotImplementedException();
        }
    }
}
