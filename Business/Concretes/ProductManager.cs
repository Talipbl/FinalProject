using Business.Abstracts;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concrete.InMemory;
using Entities.Concretes.DTOs;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        IProductDal _iProductDal;

        public ProductManager(IProductDal ProductDal)
        {
            _iProductDal = ProductDal;
        }

        public IResult BaseOperations(bool success, string message)
        {
            if (success)
            {
                return new SuccessResult(message);
            }
            return new ErrorResult(Messages.ProcessFailed);
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            return BaseOperations(_iProductDal.Add(product).Success, Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            return BaseOperations(_iProductDal.Delete(product).Success, Messages.ProductDeleted);
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(p => p.CategoryId == categoryId), Messages.ProductListed);
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_iProductDal.Get(p => p.ProductId == id));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_iProductDal.GetAll(p => p.UnitPrice > min && p.UnitPrice < max), Messages.ProductListed);
        }

        public IDataResult<List<ProductDetailDTO>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDTO>>(_iProductDal.GetProductDetails(), Messages.ProductListed);
        }

        public IResult Update(Product product)
        {
            return BaseOperations(_iProductDal.Update(product).Success, Messages.ProductUpdate);
        }
    }
}
