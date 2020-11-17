using System;
using System.Collections.Generic;
namespace ArrayList
{
    public interface IStock
    {
        ICollection<Product> GetLowItemsInStock();
    }
}