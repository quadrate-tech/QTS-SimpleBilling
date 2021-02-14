using Microsoft.EntityFrameworkCore;
using QTS.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QTS
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        internal DbSet<T> dbset;


        public Repository(DbContext context)
        {
            this.Context = context;
            this.dbset = context.Set<T>();
        }
        public void Add(T entity)
        {
            dbset.Add(entity);
        }

        public T GetRecipt(int id)
        {
            return dbset.Find(id);
        }

        public IEnumerable<T> Recipts()
        {
           return dbset.ToList();
        }

        public void Remove(T entity)
        {
            dbset.Remove(entity);
        }

        public void Remove(int id)
        {
            T entityRemove = dbset.Find(id);
            Remove(entityRemove);
        }


    }
}
