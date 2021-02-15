using System;
using System.Collections.Generic;
using System.Text;
using QTS.Models;
using System.Linq;
using QTS.BAL;

using QTS.Interface;

namespace QTS.CostRepo
{
    public class CostRepo : ICostRepo
    {
        public int Create(Cost t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                var cus = context.costs.FirstOrDefault(c => c.CostId == t.CostId);

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

        public int Delete(Cost t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.costs.Remove(t);
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
                return context.costs.Where(c => c.ItemsCode.Contains(t) ||
                                                 
                                                  c.Date.Contains(t) ||
                                                  c.CostId.ToString() == t).ToList();
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
                using BillingContext _context = new BillingContext();
                return _context.costs.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }

}
