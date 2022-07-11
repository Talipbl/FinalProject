using Core.Utilities.Results.Abstracts;
using Entities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> Get(int id);
        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);
    }
}
