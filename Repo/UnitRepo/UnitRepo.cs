using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Interface;
using QTS_SimpleBilling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Repo.UnitRepo
{
    class UnitRepo : IUnitRepo
    {
        public int Create(Unit t)
        {
            int result = 0;
            try
            {

                using BillingContext context = new BillingContext();

                var unit = context.Units.FirstOrDefault(c => c.UnitId == t.UnitId);

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

        public int Delete(Unit t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.Units.Remove(t);
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
                return context.Units.Where(c => c.UnitName.Contains(t) || c.UnitId.ToString() == t).ToList();
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
                using BillingContext context = new BillingContext();

                return context.Units.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
