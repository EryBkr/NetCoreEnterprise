using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnterpriseProject.Project.Business.Abstract;
using EnterpriseProject.Project.MVCWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseProject.Project.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {

        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products=_productService.GetList();
            ProductListViewModel model = new ProductListViewModel() {Products=products};

            return View(model);
        }
    }
}