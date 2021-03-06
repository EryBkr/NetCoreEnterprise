﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnterpriseProject.Project.Business.Abstract;
using EnterpriseProject.Project.MVCWebUI.Models;
using Microsoft.AspNetCore.Http;
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

        public IActionResult Index(int page = 1,int category=0)
        {
            int pageSize = 10;
            var products = _productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel()
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count() / (double)pageSize),
                PageSize=pageSize,
                CurrentCategory=category,
                CurrentPage=page
            };

            return View(model);
        }

        public string Session()
        {
            HttpContext.Session.SetString("isim","eray");
            var isim=HttpContext.Session.GetString("isim");
        }
    }
}