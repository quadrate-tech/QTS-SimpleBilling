using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Interface;
using QTS_SimpleBilling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Repo.CatRepo
{
    class CategoryRepo : ICategoryRepo
    {
        public int Create(Category t)
        {
            int result = 0;
            try
            {
                //Initiate the instance of DBContext
                using BillingContext context = new BillingContext();
                //check specific record for same catloyee id is exist or not
                var cat = context.Categories.FirstOrDefault(c => c.CategoryId == t.CategoryId);

                if (cat == null)
                {
                    //adding catloyee object to context
                    context.Add(t);
                    //save changes 
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

        public int Delete(Category t)
        {

            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.Categories.Remove(t);
                return result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result;
            }
        }

        public List<Category> Search(string t)
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.Categories.Where(c => c.CategoryName.Contains(t) || c.CategoryId.ToString() == t).ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }

        public int Update(Category t)
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

        public List<Category> View()
        {
            try
            {
                using BillingContext context = new BillingContext();
              
                return context.Categories.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
   

        
}

