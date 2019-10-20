using EnterpriseProject.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseProject.Project.MVCWebUI.Models
{
    public class ProductListViewModel
    {
       
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentCategory { get; set; }
        public int CurrentPage { get; set; }
        public List<Category> Categories { get; internal set; }
    }
}
