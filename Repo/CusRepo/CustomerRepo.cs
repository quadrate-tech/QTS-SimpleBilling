using QTS_SimpleBilling.Repo.CustomerRepo;
using QTS_SimpleBilling.Model;
using System.Collections.Generic;
using System.Linq;
using System;
using QTS_SimpleBilling.BAL;

namespace QTS_SimpleBilling.CusRepo
{
    public class CustomerRepo : ICustomerRepo
    {
        public int Create(Customer t)
        {
            int result = 0;
            try
            {           
                using BillingContext context = new BillingContext();
                var cus = context.Customers.FirstOrDefault(c => c.CustomerId == t.CustomerId);

                if (cus == null)
                {
                    context.Add(t);
                    return result = context.SaveChanges();
                }
                else
                {
                    return Update(t);
                }
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result = 0;
            }
        }

        public int Delete(Customer t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.Customers.Remove(t);
                return result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result;
            }
        }

        public List<Customer> Search(string t)
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.Customers.Where(c => c.CustomerName.Contains(t) ||
                                                  c.Email.Contains(t) ||
                                                  c.Address.Contains(t) ||
                                                  c.Contact.Contains(t) ||                                  
                                                  c.CustomerId.ToString() == t).ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }

        public int Update(Customer t)
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

        public List<Customer> View()
        {
            try
            {
                using BillingContext _context = new BillingContext();
                return _context.Customers.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
