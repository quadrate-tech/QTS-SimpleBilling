using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Model;
using QTS_SimpleBilling.Repo.EmployeeRepo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QTS_SimpleBilling.Repo.ReceiptBodyRepo
{
    public class ReceiptBodyRepo : IReceiptBodyRepo
    {
        public int Create(ReceiptBody t)
        {
            int result = 0;
            try
            {
                //Initiate the instance of DBContext
                using BillingContext context = new BillingContext();
                //check specific record for same ReceiptNo is exist or not
                var receipt = context.ReceiptBodies.FirstOrDefault(c => c.ReceiptNo == t.ReceiptNo);
                if (receipt == null)
                {
                    //adding receiptbody object to context
                    context.Add(t);
                    //save changes 
                    return result = context.SaveChanges();
                }
                else
                {
                    context.Update(t);
                    return result = context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result = 0;
            }
        }

        public int Delete(ReceiptBody t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.ReceiptBodies.Remove(t);
                return result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result;
            }
        }

        public List<ReceiptBody> Search(string t)
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.ReceiptBodies.Where(c => c.ProductCode.Contains(t) ||
                                                  c.UnitPrice.Contains(t) ||
                                                  c.Quantity.Contains(t) ||
                                                  c.Discount.Contains(t) ||
                                                  c.SubTotal.Contains(t) ||
                                                  c.NetTotal.Contains(t) ||
                                                  c.ReceiptNo.ToString() == t).ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }

        public int Update(ReceiptBody t)
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

        public List<ReceiptBody> View()
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.ReceiptBodies.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }

    }
}
