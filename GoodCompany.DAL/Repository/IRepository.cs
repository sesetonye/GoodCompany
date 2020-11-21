using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCompany.DAL
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
    }
}
