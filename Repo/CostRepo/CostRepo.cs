using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Interface;
using QTS_SimpleBilling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Repo.CostRepo
{
    class CostRepo : ICostRepo
    {
        public int Create(Cost t)
        {
            int result = 0;
            try
            {

                using BillingContext context = new BillingContext();

                var unit = context.Costs.FirstOrDefault(c => c.CostId == t.CostId);

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

        public int Delete(Cost t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.Costs.Remove(t);
                return result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result;
            }
        }

        public List<Cost> Search(string t)
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.Costs.Where(c => c.ItemCost.ToString() == t || c.ItemId.ToString() == t || c.CostId.ToString() == t).ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }

        public int Update(Cost t)
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

        public List<Cost> View()
        {
            try
            {
                using BillingContext context = new BillingContext();

                return context.Costs.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
