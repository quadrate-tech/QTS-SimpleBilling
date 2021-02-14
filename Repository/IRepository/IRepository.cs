using System;
using System.Collections.Generic;
using System.Text;

namespace QTS.IRepository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        void Remove(int id);
        T GetRecipt(int id);
        IEnumerable<T> Recipts();

    }
}
