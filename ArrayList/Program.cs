using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Mama Africa Rice 50Kg", DateTime.Now, DateTime.Now, 26000M, 10);
            Product product2 = new Product("Golden Penny SemoVita 5Kg", DateTime.Now, DateTime.Now, 2000M, 4);
            Product product3 = new Product("Dangote Cement", DateTime.Now, DateTime.Now, 2800M, 3);
            Product product4 = new Product("Peak Milk", DateTime.Now, DateTime.Now, 170M, 2);

            ICollection<Product> allProducts = new List<Product>(){product1, product2, product3, product4};

            IStock stock = new Stock(allProducts);

            var itemsLowInStock = stock.GetLowItemsInStock();

            foreach (var item in itemsLowInStock)
            {
                Console.WriteLine(item);
            }
        }
    }
}
