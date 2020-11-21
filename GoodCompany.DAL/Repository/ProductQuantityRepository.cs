using GoodCompany.Entity;
using GoodCompany.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodCompany.DAL
{
    public class ProductQuantityRepository : Repository<ProductQuantity>, IProductQuantityRepository
    {
        private readonly ApplicationDbContext _productDbEntities;
        public ProductQuantityRepository(ApplicationDbContext context) : base(context)
        {
            _productDbEntities = context;
        }
      
    }
}
