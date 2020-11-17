using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArrayList
{
    public class Stock : IStock
    {
        public ICollection<Product> ProductsInStock { get; set; } = new Collection<Product>();
        public Stock(ICollection<Product> products)
        {
            ProductsInStock = products;
        }

        public ICollection<Product> GetLowItemsInStock()
        {
            ICollection<Product> lowItems = new Collection<Product>();
            if(ProductsInStock.Count > 0)
            {
                foreach (var item in ProductsInStock)
                {
                    if (item.Quantity < 5)
                    {
                        lowItems.Add(item);
                    }
                }
            }
            return lowItems;
        }
    }
}