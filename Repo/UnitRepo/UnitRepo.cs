using System;
using System.Collections.Generic;
using System.Text;
using QTS.BAL;
using System.Linq;
using QTS.Interface;
using QTS.Models;

namespace QTS.UnitRepo
{
    public class UnitRepo : IUniteRepo
    {
        public int Create(Unit t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                var cus = context.units.FirstOrDefault(c => c.UnitId == t.UnitId);

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

        public int Delete(Unit t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.units.Remove(t);
                return result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result;
            }
        }

        public List<Unit> Search(string t)
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.units.Where(c => c.UnitName.Contains(t) ||

                                                  c.UnitId.ToString() == t).ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }

        public int Update(Unit t)
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

        public List<Unit> View()
        {
            try
            {
                using BillingContext _context = new BillingContext();
                return _context.units.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
