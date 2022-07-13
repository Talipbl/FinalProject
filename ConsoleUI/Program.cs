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
            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //foreach (var item in categoryManager.GetAll())
            //{
            //    Console.WriteLine(item.CategoryName);
            //}
        }

        private static void GetProducts()
        {
            //ProductManager productManager = new ProductManager(new EfProductDal());
            //var result = productManager.GetProductDetails();
            //if (result.Success)
            //{
            //    foreach (var item in result.Data)
            //    {
            //        Console.WriteLine(item.ProductName + " / " + item.CategoryName);
            //    }
            //}
            //Console.WriteLine("\n" + result.Message);
        }
    }
}
