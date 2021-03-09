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
            //Data Transformation Object = DTO
            ProductTest();
            //CategoryTest();


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName+"/"+product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            /*
            foreach (var product in .)
            {

                Console.WriteLine("Ürün ismi : " + product.ProductName);
                Console.WriteLine("Ürün fiyatı : " + product.CategoryName);
                Console.WriteLine("Ürün stoğu : " + product.UnitsInStock);
                Console.WriteLine("------------------------------");

            }
            */

        }
    }
}
