using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Interface;
using QTS_SimpleBilling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Repo.ShelfRepo
{
    class ShelfRepo : IShelfRepo
    {
        public int Create(Shelf t)
        {
            int result = 0;
            try
            {
               
                using BillingContext context = new BillingContext();
                
                var cat = context.Shelves.FirstOrDefault(c => c.ShelfId == t.ShelfId);

                if (cat == null)
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
                context.Shelves.Remove(t);
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
                return context.Shelves.Where(c => c.ShelfName.Contains(t) || c.ShelfId.ToString() == t).ToList();
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
                using BillingContext context = new BillingContext();

                return context.Shelves.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
