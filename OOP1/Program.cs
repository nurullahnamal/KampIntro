using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Product product1 = new Product();
            product1.Id = 1;
            product1.CatergoryId = 2;
            product1.ProductName = "PC";
            product1.UnitPrice = 100;
            product1.UnitPrice = 93;


            Product product2 = new Product { Id = 2, CatergoryId = 4, UnitInStock = 5, UnitPrice = 32, ProductName = "zort" };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            productManager.Topla2(2, 6);
         



        }
    }
}
