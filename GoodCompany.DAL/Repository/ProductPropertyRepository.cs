using GoodCompany.Entity;
using GoodCompany.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodCompany.DAL
{
    public class ProductPropertyRepository : Repository<ProductProperty>, IProductPropertyRepository
    {
        private readonly ApplicationDbContext _productDbEntities;
        public ProductPropertyRepository(ApplicationDbContext context) : base(context)
        {
            _productDbEntities = context;
        }
      
    }
}
