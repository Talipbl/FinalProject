using Business.Concrete;
using Business.Concretes;
using DataAccess.Concrete.InMemory;
using DataAccess.Concretes.EntityFrameworks;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GetProducts();
            //GetCategories();

            Console.ReadKey();
        }

        private static void GetCategories()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void GetProducts()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName + " / " + item.CategoryName);
            }
        }
    }
}
