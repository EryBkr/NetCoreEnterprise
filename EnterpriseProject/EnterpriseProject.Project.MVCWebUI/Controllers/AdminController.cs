using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnterpriseProject.Project.Business.Abstract;
using EnterpriseProject.Project.Entities.Concrete;
using EnterpriseProject.Project.MVCWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseProject.Project.MVCWebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        IProductService _productService;
        ICategoryService _categoryService;
        
        public AdminController(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new ProductListViewModel()
            {
                Categories = _categoryService.GetList()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                TempData["message"] = "product Eklendi";
                return RedirectToAction("Add");
            }

            return View();
        }
        public IActionResult Index()
        {
            var products = new ProductListViewModel()
            {
                Products = _productService.GetList()
            };
            return View(products);
        }
    }
}