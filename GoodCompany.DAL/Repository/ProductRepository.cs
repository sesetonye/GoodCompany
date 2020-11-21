using GoodCompany.Entity;
using GoodCompany.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodCompany.DAL
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _productDbEntities;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _productDbEntities = context;
        }
        IEnumerable<Product> IProductRepository.GetTopProducts(int number)
        {
            return _productDbEntities.Product.Take(number).ToList();
        }
    }
}
