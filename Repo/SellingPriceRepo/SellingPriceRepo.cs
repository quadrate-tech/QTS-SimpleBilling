using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Interface;
using QTS_SimpleBilling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Repo.SellingPriceRepo
{
    class SellingPriceRepo : ISellingPriceRepo
    {
        public int Create(SellingPrice t)
        {
            int result = 0;
            try
            {

                using BillingContext context = new BillingContext();

                var unit = context.SellingPrices.FirstOrDefault(c => c.PriceId == t.PriceId);

                if (unit == null)
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
                context.SellingPrices.Remove(t);
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
                return context.SellingPrices.Where(c => c.PriceId.ToString() == t || c.ItemPrice.ToString() == t || c.ItemId.ToString() == t).ToList();
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
                using BillingContext context = new BillingContext();

                return context.SellingPrices.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
