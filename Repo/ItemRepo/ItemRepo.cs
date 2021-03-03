using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Interface;
using QTS_SimpleBilling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Repo.ItemRepo
{
    class ItemRepo : IItemRepo
    {
        public int Create(Item t)
        {
            int result = 0;
            try
            {
               
                using BillingContext context = new BillingContext();
              
                var item = context.Items.FirstOrDefault(c => c.ItemId == t.ItemId);

                if (item == null)
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

        public int Delete(Item t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.Items.Remove(t);
                return result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result;
            }
        }

        public List<Item> Search(string t)
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.Items.Where(c => c.ItemName.Contains(t) ||
                                                  c.ItemBarcode.Contains(t) ||                                     
                                                  c.ItemId.ToString() == t).ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }

        public int Update(Item t)
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

        public List<Item> View()
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.Items.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
