using QTS_SimpleBilling.BAL;
using QTS_SimpleBilling.Interface;
using QTS_SimpleBilling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QTS_SimpleBilling.Repo.UserRepo
{
    class UserRepo : IUserRepo
    {
        public int Create(User t)
        {
            int result = 0;
            try
            {
                //Initiate the instance of DBContext
                using BillingContext context = new BillingContext();
                //check specific record for same employee id is exist or not
                var u = context.Users.FirstOrDefault(c => c.UserID == t.UserID);

                if (u == null)
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

        public int Delete(User t)
        {
            int result = 0;
            try
            {
                using BillingContext context = new BillingContext();
                context.Users.Remove(t);
                return result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return result;
            }
        }

        public List<User> Search(string t)
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.Users.Where(c => c.UserName.Contains(t) ||
                                                  c.UserType.Contains(t)||
                                                  c.UserID.ToString() == t).ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }

        public int Update(User t)
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

        public List<User> View()
        {
            try
            {
                using BillingContext context = new BillingContext();
                return context.Users.ToList();
            }
            catch (Exception ex)
            {
                Exc.ErMessage(ex);
                return null;
            }
        }
    }
}
