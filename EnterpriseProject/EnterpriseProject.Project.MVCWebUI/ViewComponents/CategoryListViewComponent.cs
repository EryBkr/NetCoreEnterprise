using EnterpriseProject.Project.Business.Abstract;
using EnterpriseProject.Project.MVCWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseProject.Project.MVCWebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel() 
            { 
                Categories = _categoryService.GetList(),
                CurrentCategory=Convert.ToInt32(HttpContext.Request.Query["category"])
            };
        
            return View(model);
        }

    }
}
