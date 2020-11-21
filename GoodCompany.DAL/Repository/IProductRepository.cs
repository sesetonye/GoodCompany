using GoodCompany.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCompany.DAL
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetTopProducts(int number);
    }
}
