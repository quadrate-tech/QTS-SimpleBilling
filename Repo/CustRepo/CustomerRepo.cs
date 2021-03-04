using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Model;
//using QTS_SimpleBilling.Repo.CustomerRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using QTS_SimpleBilling.Interface;

namespace QTS_SimpleBilling.CustRepo
{
    public class CustomerRepo : ICustomerRepo
    {
        public int Create(Customer t)
        {
            int result = 0;
            try
            {
                //Initiate the instance of DBContext
                using BillingContext context = new BillingContext();
                //check specific record for same Customer id is exist or not
                var cust = context.Customers.FirstOrDefault(c => c.CustomerId == t.CustomerId);

                if (cust == null)
                {
                    //adding Customer object to context
                    context.Add(t);
                    //save changes 
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
                using BillingContext context = new BillingContext();
                return context.Customers.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
