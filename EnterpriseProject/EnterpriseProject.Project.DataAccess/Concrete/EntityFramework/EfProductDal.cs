using EnterpriseProject.Core.DataAcess.EntityFramework;
using EnterpriseProject.Project.DataAccess.Abstract;
using EnterpriseProject.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseProject.Project.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<MyContext, Product>, IProductDal
    {
        public List<Product> GetByCategory(int categoryId)
        {
            using (var context=new MyContext())
            {
                List<Product> products;
                if (categoryId>0)
                {
                     products = context.Products.Where(i => i.CategoryId == categoryId).ToList();
                }
                else
                {
                     products = context.Products.ToList();
                }
                
                return products;
            }
        }
    }
}
