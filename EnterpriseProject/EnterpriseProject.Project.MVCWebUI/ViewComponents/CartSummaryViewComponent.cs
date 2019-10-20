using EnterpriseProject.Project.Entities.Concrete;
using EnterpriseProject.Project.MVCWebUI.Models;
using EnterpriseProject.Project.MVCWebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseProject.Project.MVCWebUI.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {
        ICartSessionService _cartSession;

        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSession = cartSessionService;
        }

        public  IViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel()
            {
                 cart=_cartSession.GetCart()
            };

        return View(model);
        }
    }
}
