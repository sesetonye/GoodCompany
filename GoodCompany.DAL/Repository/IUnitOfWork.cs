using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCompany.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        IBrandRepository Brands { get; }
        IComputerTypeRepository ComputerTypes { get; }
        IProductQuantityRepository ProductQuantity { get; }
        IProductPropertyRepository ProductProperty { get; }

        int Complete();
    }
}
