using System.Collections.Generic;

namespace QTS_SimpleBilling.Interface
{
    internal interface CRUDInterface<T>
    {
        int Create(T t);
        int Update(T t);
        int Delete(T t);
        List<T> View();
        List<T> Search(string t);
    }
}
