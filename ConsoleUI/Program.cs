using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concretes.EntityFrameworks;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetByUnitPrice(10, 20))
            {
                Console.WriteLine(item.ProductName);
            }
            Console.ReadKey();
        }
    }
}
