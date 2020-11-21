using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodCompany.DAL;
using GoodCompany.Web.ViewModel;
using GoodCompany.Web.ViewService;
using Microsoft.AspNetCore.Mvc;

namespace GoodCompany.Web.Controllers
{


    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProductViewService _productViewService;
        //private readonly IHostingEnvironment hostingEnvironment;
        //private readonly ILogger<HomeController> logger;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _productViewService = new ProductViewService(_unitOfWork);
        }

        public IActionResult Index()
        {
            var products = _unitOfWork.Products.GetAll();
            var model = new List<ProductViewModel>();
            foreach (var product in products)
            {
                model.Add(_productViewService.ConvertProductToProductViewModel(product));
            }
            return View(model);
        }
        public IActionResult Detail(Guid id)
        {
            var products = _unitOfWork.Products.GetById(id);
            return View(_productViewService.ConvertProductToProductViewModel(products));
        }
        public ViewResult Add()
        {
            var model = _productViewService.NewProductViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(ProductViewModel model)
        {
            model.ProductId = Guid.NewGuid();
            var product = _productViewService.ConvertProductViewModelToProduct(model);
            _unitOfWork.Products.Add(product);
            var quantity = _productViewService.ConvertProductViewModelToProductQuantity(model);
            _unitOfWork.ProductQuantity.Add(quantity);
            var property = _productViewService.ConvertProductViewModelToProductProperty(model);
            _unitOfWork.ProductProperty.Add(property);

            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }


    }
}