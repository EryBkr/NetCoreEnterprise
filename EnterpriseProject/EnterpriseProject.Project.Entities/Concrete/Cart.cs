using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseProject.Project.Entities.Concrete
{
    public class Cart
    {
        public Cart()
        {
            CartLLines = new List<CartLine>();
        }
        public List<CartLine> CartLLines { get; set; }
        public decimal Total { get { return CartLLines.Sum(c => c.Product.UnitPrice * c.Quantity); } }


    }
}
