using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTSSimple_Billing.Interface
{
    internal interface CRUD<T>
    {
        int Create(T t);
        int Update(T t);
        int Delete(T t);
        List<T> View();
        List<T> Search(string t);
    }
}
