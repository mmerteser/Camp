using Camp.Bussines.Concrete;
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
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetAllByCategoryId(3))
            {
                Console.WriteLine(item.ProductName + " Kategori Id ++++++++++++++++++");
            }

            foreach (var item in productManager.GetAllByUnitPrice(10, 15))
            {
                Console.WriteLine(item.ProductName + " Unit Price --------------------");
            }

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName + "                      ???????????????");
            }
        }
    }
}
