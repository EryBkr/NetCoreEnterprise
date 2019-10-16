using EnterpriseProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseProject.Project.Entities.Concrete
{
    public class CartLine
    {
        
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }

   
}
