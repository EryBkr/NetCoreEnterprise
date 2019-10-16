using EnterpriseProject.Core.DataAcess.Abstract;
using EnterpriseProject.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseProject.Project.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<Product> GetByCategory(int categoryId);
    }
}
