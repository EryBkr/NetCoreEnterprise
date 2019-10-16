using EnterpriseProject.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseProject.Project.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart,Product product);
        void RemoveCart(Cart cart,int productId);
        List<CartLine> List(Cart cart);
    }
}
