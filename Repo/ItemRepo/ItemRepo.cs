using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Interface;
using QTS_SimpleBilling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling
{
    class ItemRepo : IItemRepo
    {
        public int Create(Item t)
        {
            int result = 0;
            try
            {
                //Initiate the instance of DBContext
                using BillingContext context = new BillingContext();
                //check specific record for same employee id is exist or not
                var emp = context.Employees.FirstOrDefault(c => c.EmployeeId == t.ItemId);

                if (emp == null)
                {
                    //adding employee object to context
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

        public int Delete(Item t)
        {
            throw new NotImplementedException();
        }

        public List<Item> Search(string t)
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.Items.Where(c => c.ItemCode.Contains(t) ||
                                                  c.ItemName.Contains(t)).ToList();



            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }


        

        public int Update(Item t)
        {
            throw new NotImplementedException();
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
