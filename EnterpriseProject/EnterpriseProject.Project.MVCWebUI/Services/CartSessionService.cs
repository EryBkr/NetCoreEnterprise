using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnterpriseProject.Project.Entities.Concrete;
using EnterpriseProject.Project.MVCWebUI.ExtensionsMethod;
using Microsoft.AspNetCore.Http;

namespace EnterpriseProject.Project.MVCWebUI.Services
{
    public class CartSessionService : ICartSessionService
    {
        private IHttpContextAccessor _httpContext;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContext = httpContextAccessor;
        }

        public Cart GetCart()
        {
           var cartToCheck= _httpContext.HttpContext.Session.GetObject<Cart>("cart");
            if (cartToCheck==null)
            {
                _httpContext.HttpContext.Session.SetObject("cart", new Cart());
                cartToCheck = _httpContext.HttpContext.Session.GetObject<Cart>("cart");
            }

            return cartToCheck;

        }

        public void SetCart(Cart cart)
        {
            _httpContext.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
