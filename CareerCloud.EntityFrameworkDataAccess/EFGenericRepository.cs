using CareerCloud.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class EfGenericRepository<T> : IDataRepository<T> where T : class
    {
        private CareerCloudContext context;
        public EfGenericRepository()
        {
            context = new CareerCloudContext();
        }
        public void Add(params T[] items)
        {
            foreach (T item in items)
            {
                context.Entry(item).State = EntityState.Added;
            }
            context.SaveChanges();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = context.Set<T>();
            foreach (Expression<Func<T, object>> property in navigationProperties)
            {
                dbQuery = dbQuery.Include<T, object>(property);
            }
            return dbQuery.ToList();
        }

        public IList<T> GetList(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = context.Set<T>();
            foreach (var item in navigationProperties)
            {
                dbQuery = dbQuery.Include<T, object>(item);
            }
            return dbQuery.Where(where).ToList<T>();
        }

        public T GetSingle(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = context.Set<T>();
            foreach (var item in navigationProperties)
            {
                dbQuery = dbQuery.Include<T, object>(item);
            }
            
            return dbQuery.Where(where).FirstOrDefault();
        }

        public void Remove(params T[] items)
        {
            foreach (T item in items)
            {
                context.Entry(item).State = EntityState.Deleted;
            }            
            context.SaveChanges();
        }

        public void Update(params T[] items)
        {
            foreach (T item in items)
            {
                context.Entry(item).State = EntityState.Modified;
            }            
            context.SaveChanges();
        }
    }
}
