using QTS.Models;
using System;
using QTS.BAL;
using System.Linq;
using System.Collections.Generic;
using QTS.Interface;

namespace QTS.ShelfRepo
{
    public class ShelfRepo : IShelfRepo
    {
        public int Create(Shelf t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                var cus = context.shelves.FirstOrDefault(c => c.ShelfId == t.ShelfId);

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

        public int Delete(Shelf t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.shelves.Remove(t);
                return result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result;
            }
        }

        public List<Shelf> Search(string t)
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.shelves.Where(c => c.ShelfName.Contains(t)||
                                                
                                                  c.ShelfId.ToString() == t).ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }

        public int Update(Shelf t)
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

        public List<Shelf> View()
        {
            try
            {
                using BillingContext _context = new BillingContext();
                return _context.shelves.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
