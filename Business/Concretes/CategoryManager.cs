using Business.Abstracts;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            return _categoryDal.Add(category);
        }

        public IResult Delete(Category category)
        {
            return _categoryDal.Delete(category);
        }

        public IDataResult<Category> Get(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryId == id));
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IResult Update(Category category)
        {
            return _categoryDal.Update(category);
        }
    }
}
