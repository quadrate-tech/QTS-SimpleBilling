using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_SimpleBilling.Interface
{
    internal interface CRUDInterface<T>
    {
        int Create(T t);
        int Update(T t);
        int Delete(T t);
        List<T> View();
    }
}
