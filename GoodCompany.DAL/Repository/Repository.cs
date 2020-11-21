using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GoodCompany.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _entities;
        public Repository(DbContext context)
        {
            _entities = context.Set<T>();
        }
        void IRepository<T>.Add(T entity)
        {
            _entities.Add(entity);
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            return _entities.ToList();
        }

        T IRepository<T>.GetById(int id)
        {
            return _entities.Find(id);
        }
        T IRepository<T>.GetById(Guid id)
        {
            return _entities.Find(id);
        }

        void IRepository<T>.Remove(T entity)
        {
            _entities.Remove(entity);
        }

        IEnumerable<T> IRepository<T>.Find(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

    }
}
