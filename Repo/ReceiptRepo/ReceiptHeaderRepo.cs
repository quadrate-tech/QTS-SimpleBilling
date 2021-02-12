using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Model;
using QTS_SimpleBilling.Repo.ReceiptHeaderRepo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QTS_SimpleBilling.ReceiptRepo
{
    public class ReceiptHeaderRepo : IReceiptHeaderRepo
    {
        public int Create(ReceiptHeader t)
        {
            int result = 0;
            try
            {
                //Initiate the instance of DBContext
                using BillingContext context = new BillingContext();
                //check specific record for same receipt no is exist or not
                var receipt = context.ReceiptHeaders.FirstOrDefault(c => c.ReceiptNo == t.ReceiptNo);

                if (receipt == null)
                {
                    //adding receipt header object to context
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

        public int Delete(ReceiptHeader t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.ReceiptHeaders.Remove(t);
                return result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result;
            }
        }

        public List<ReceiptHeader> Search(string t)
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.ReceiptHeaders.Where(c => c.Date.Contains(t) ||
                                                  c.Time.Contains(t) ||
                                                  c.Employee.Contains(t) ||
                                                  c.CheckNo.Contains(t) ||
                                                  c.ReceiptNo.ToString() == t ||
                                                  c.TotalDiscount.ToString() == t ||
                                                  c.SubTotal.ToString() == t ||
                                                  c.NetTotal.ToString() == t ||
                                                  c.PaidAmount.ToString() == t ||
                                                  c.DueAmount.ToString() == t ||
                                                  c.Status.ToString() == t ||
                                                  c.IsQuotation.ToString() == t ||
                                                  c.IsPaid.ToString() == t).ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }

        public int Update(ReceiptHeader t)
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

        public List<ReceiptHeader> View()
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.ReceiptHeaders.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
