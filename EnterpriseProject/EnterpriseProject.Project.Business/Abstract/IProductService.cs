using EnterpriseProject.Core.Bussiness.Abstract;
using EnterpriseProject.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseProject.Project.Business.Abstract
{
   public interface IProductService:IGenericService<Product>
    {
        List<Product> GetByCategory(int categoryId);
    }
}
