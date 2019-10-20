using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnterpriseProject.Project.Business.Abstract;
using EnterpriseProject.Project.Entities.Concrete;
using EnterpriseProject.Project.MVCWebUI.Models;
using EnterpriseProject.Project.MVCWebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseProject.Project.MVCWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartService cartService,ICartSessionService cartSessionService,IProductService productService)
        {
            _cartService = cartService;
            _cartSessionService = cartSessionService;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            var product = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, product);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", "ürün eklendş");
            return RedirectToAction("Index", "Product");
           
        }

        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            var cartModel = new CartSummaryViewModel();
            cartModel.cart = cart;

            return View(cartModel);  
        }

        public IActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveCart(cart,productId);
            _cartSessionService.SetCart(cart);

            return RedirectToAction("List","Cart");
        }

        [HttpGet]
        public IActionResult Complete()
        {

            var shipping = new ShippingDetailsModel()
            {
                ShippingDetail=new ShippingDetails()
            };

            return View(shipping);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Complete(ShippingDetails shippingDetails)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            TempData["message"] = "sipariş başarılı";
            return View();
        }
    }
}