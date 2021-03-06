using Core.Utilities.Results;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes.DTOs;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=10},
                new Product{ProductId=2, CategoryId=1, ProductName="Çatal", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Klavye", UnitPrice=1500, UnitsInStock=60},
                new Product{ProductId=4, CategoryId=2, ProductName="Monitör", UnitPrice=150, UnitsInStock=1}
            };
        }
        public IResult Add(Product product)
        {
            _products.Add(product);
            return new SuccessResult();
        }

        public IResult Delete(Product product)
        {
            Product productToDelete = null;
            productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
            return new SuccessResult();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDTO> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            return new SuccessResult();
        }
    }
}
