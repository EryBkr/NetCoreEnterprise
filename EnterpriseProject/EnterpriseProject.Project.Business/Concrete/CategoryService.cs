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
    public class CategoryService : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public Category Get(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.Get();
        }

        public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.GetList();
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
