using System;
using System.Collections.Generic;
using System.Text;
using QTS.Models;
using System.Linq;
using QTS.BAL;
using QTS.Interface;

namespace QTS.ItemsRepo
{
    public class ItemsRepo : IItemsRepo
    {
        public int Create(Items t)
        {

            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                var cus = context.itemes.FirstOrDefault(c => c.ItemsId == t.ItemsId);

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

        public int Delete(Items t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.itemes.Remove(t);
                return result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result;
            }
        }

        public List<Items> Search(string t)
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.itemes.Where(c => c.ItemsBarcode.Contains(t) ||
                                                  c.ItemsCatagory.Contains(t) ||
                                                  c.ItemsUnit.Contains(t) ||
                                                  c.Shelf.Contains(t) ||
                                                  c.IsService.Contains(t) ||
                                                  c.ItemsName.Contains(t) ||
                                                  c.ItemsId.ToString() == t).ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }

        public int Update(Items t)
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

        public List<Items> View()
        {
            try
            {
                using BillingContext _context = new BillingContext();
                return _context.itemes.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
