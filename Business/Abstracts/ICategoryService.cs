using Entities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category Get(int id);
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
