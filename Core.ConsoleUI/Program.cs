﻿using Camp.Bussines.Concrete;
using Camp.DataAccess.Concrete.EntityFramework;
using Camp.DataAccess.Concrete.InMemory;
using Camp.Entities.Concrete;
using System;

namespace Core.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            ProductDetailsTest();

        }

        private static void ProductDetailsTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + " / " + item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message); 
            }

            
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetAllByUnitPrice(10, 15).Data)
            {
                Console.WriteLine(item.ProductName + " Unit Price --------------------");
            }
        }
    }
}
