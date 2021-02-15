using QTS.Interface;
using QTS.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using QTS.BAL;

namespace QTS.SellPriceRepo
{
    public class SellPriceRepo : ISellingPrice
    {
        public int Create(SellingPrice t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                var cus = context.sellingPrices.FirstOrDefault(c => c.PricId == t.PricId);

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

        public int Delete(SellingPrice t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.sellingPrices.Remove(t);
                return result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result;
            }
        }

        public List<SellingPrice> Search(string t)
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.sellingPrices.Where(c => c.Price.ToString("C2") == t ||                                      
                                                  c.Date.Contains(t) ||
                                                  c.PricId.ToString() == t).ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }

        public int Update(SellingPrice t)
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

        public List<SellingPrice> View()
        {
            try
            {
                using BillingContext _context = new BillingContext();
                return _context.sellingPrices.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
