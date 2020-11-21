using GoodCompany.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCompany.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IProductRepository Products { get; }
        public IComputerTypeRepository ComputerTypes { get; }
        public IBrandRepository Brands { get; }
        public IProductQuantityRepository ProductQuantity { get; }
        public IProductPropertyRepository ProductProperty { get; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
            ComputerTypes = new ComputerTypeRepository(_context);
            Brands = new BrandRepository(_context);
            ProductQuantity = new ProductQuantityRepository(_context);
            ProductProperty = new ProductPropertyRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
