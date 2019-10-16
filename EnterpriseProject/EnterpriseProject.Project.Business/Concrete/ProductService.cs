using EnterpriseProject.Core.Bussiness.Abstract;
using EnterpriseProject.Project.Business.Abstract;
using EnterpriseProject.Project.DataAccess.Abstract;
using EnterpriseProject.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EnterpriseProject.Project.Business.Concrete
{
    public class ProductService : IProductService
    {

        IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product entity)
        {
            _productDal.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            return _productDal.Get();
        }

        public List<Product> GetByCategory(int categoryId)
        {
           return _productDal.GetByCategory(categoryId);
        }

        public List<Product> GetList(Expression<Func<Product, bool>> filter = null)
        {
            return _productDal.GetList();
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
