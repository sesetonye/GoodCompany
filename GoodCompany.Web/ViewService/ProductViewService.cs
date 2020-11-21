using GoodCompany.DAL;
using GoodCompany.Entity;
using GoodCompany.Web.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Web.ViewService
{
    public class ProductViewService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductViewService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ProductViewModel NewProductViewModel()
        {
            return new ProductViewModel
            {
                ComputerTypeList = _unitOfWork.ComputerTypes.GetAll().Select(x => new SelectListItem(x.Name.ToString(), x.Id.ToString())),
                BrandList = _unitOfWork.Brands.GetAll().Select(x => new SelectListItem(x.Name.ToString(), x.Id.ToString())),
            };
        }

        public ProductViewModel ConvertProductToProductViewModel(Product product )
        {
            var model = NewProductViewModel();
            model.Name = product.Name;
            model.Processor = product.ProductProperty.Processor;
            model.Quantity = product.ProductQuantity.Quantity;
            model.RamSlots = product.ProductProperty.RamSlots;
            model.ScreenSize = product.ProductProperty.ScreenSize;
            model.UsbPorts = product.ProductProperty.UsbPorts;
            model.Id = product.Id;
            return model;

        } 

        public Product ConvertProductViewModelToProduct(ProductViewModel product)
        {
            var model = new Product()
            {
                Name = product.Name,
                ProductId = product.ProductId,
                Id = product.Id
            };
            return model;
        }

        public ProductQuantity ConvertProductViewModelToProductQuantity(ProductViewModel product)
        {
            var model = new ProductQuantity()
            {
                Quantity = product.Quantity,
                ProductId = product.ProductId,
                Id = product.Id
            };
            return model;
        }
        public ProductProperty ConvertProductViewModelToProductProperty(ProductViewModel product)
        {
            var model = new ProductProperty()
            {
                RamSlots = product.RamSlots,
                Processor = product.Processor,
                ScreenSize = product.ScreenSize,
                UsbPorts = product.UsbPorts,
                BrandId = product.BrandId,
                ComputerTypeId = product.ComputerTypeId,
                ProductId = product.ProductId,
                Id = product.Id
            };
            return model;
        }

    }
}
