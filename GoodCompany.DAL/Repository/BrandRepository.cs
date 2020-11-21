using GoodCompany.Entity;
using GoodCompany.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodCompany.DAL
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        private readonly ApplicationDbContext _productDbEntities;
        public BrandRepository(ApplicationDbContext context) : base(context)
        {
            _productDbEntities = context;
        }
      
    }
}
