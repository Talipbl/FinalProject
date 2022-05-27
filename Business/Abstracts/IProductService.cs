using Core.Utilities.Results.Abstracts;
using Entities.Concretes.DTOs;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<Product> GetById(int id);
        IDataResult<List<ProductDetailDTO>> GetProductDetails();
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
