using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concretes.DTOs;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _iProductDal;

        public ProductManager(IProductDal ProductDal)
        {
            _iProductDal = ProductDal;
        }

        public void Add(Product product)
        {
            _iProductDal.Add(product);
        }

        public void Delete(Product product)
        {
            _iProductDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _iProductDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _iProductDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _iProductDal.GetAll(p => p.UnitPrice > min && p.UnitPrice < max);
        }

        public List<ProductDetailDTO> GetProductDetails()
        {
            return _iProductDal.GetProductDetails();
        }

        public void Update(Product product)
        {
            _iProductDal.Update(product);
        }
    }
}
