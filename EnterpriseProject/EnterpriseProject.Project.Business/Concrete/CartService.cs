using EnterpriseProject.Project.Business.Abstract;
using EnterpriseProject.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EnterpriseProject.Project.Business.Concrete
{
    public class CartService : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLLines.FirstOrDefault(c => c.Product.Id == product.Id);
            if (cartLine!=null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLLines.Add(new CartLine() { Product = product, Quantity = 1 });
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLLines.ToList();
        }

        public void RemoveCart(Cart cart, int productId)
        {
            cart.CartLLines.Remove(cart.CartLLines.FirstOrDefault(c=>c.Product.Id==productId));
        }
    }
}
