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
            var property = _unitOfWork.ProductProperty.Find(x => x.ProductId == product.ProductId).FirstOrDefault();
            var quantity = _unitOfWork.ProductQuantity.Find(x => x.ProductId == product.ProductId).FirstOrDefault();

            model.Name = product.Name;            
            model.Processor = property.Processor;
            model.Quantity = quantity.Quantity;
            model.RamSlots = property.RamSlots;
            model.ScreenSize = property.ScreenSize;
            model.UsbPorts = property.UsbPorts;
            model.ProductId = product.ProductId;
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
