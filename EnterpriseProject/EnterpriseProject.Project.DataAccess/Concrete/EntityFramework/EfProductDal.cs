using EnterpriseProject.Core.DataAcess.EntityFramework;
using EnterpriseProject.Project.DataAccess.Abstract;
using EnterpriseProject.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseProject.Project.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<MyContext,Product>,IProductDal
    {
    }
}
