using GoodCompany.Entity;
using GoodCompany.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodCompany.DAL
{
    public class ComputerTypeRepository : Repository<ComputerType>, IComputerTypeRepository
    {
        private readonly ApplicationDbContext _DbEntities;
        public ComputerTypeRepository(ApplicationDbContext context) : base(context)
        {
            _DbEntities = context;
        }
      
    }
}
