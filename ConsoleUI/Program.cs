using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            /*
            foreach (var product in productManager.GetAll())
            {
                
                Console.WriteLine("Ürün ismi : " + product.ProductName);
                Console.WriteLine("Ürün fiyatı : " + product.UnitPrice);
                Console.WriteLine("Ürün stoğu : " + product.UnitsInStock);
                Console.WriteLine("------------------------------");

            }
            */
            /*
            foreach (var product in productManager.GetAllByCategory(2))
            {

                Console.WriteLine("Ürün ismi : " + product.ProductName);
                Console.WriteLine("Ürün fiyatı : " + product.UnitPrice);
                Console.WriteLine("Ürün stoğu : " + product.UnitsInStock);
                Console.WriteLine("------------------------------");

            }
            */
            foreach (var product in productManager.GetByUnitPrice(10,25))
            {

                Console.WriteLine("Ürün ismi : " + product.ProductName);
                Console.WriteLine("Ürün fiyatı : " + product.UnitPrice);
                Console.WriteLine("Ürün stoğu : " + product.UnitsInStock);
                Console.WriteLine("------------------------------");

            }


        }
    }
}
