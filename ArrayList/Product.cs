using System;
namespace ArrayList
{
    public class Product
    {
        public string ItemName { get; set; }
        public DateTime ManDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string itemName, DateTime manDate, DateTime expiryDate, decimal price, int quantity)
        {
            ItemName = itemName;
            ManDate = manDate;
            ExpiryDate = expiryDate;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Item: {ItemName}\nPrice: {Price:C}\nManufacturing Date: {ManDate}\nExpiry Date: {ExpiryDate}\nQuantity In Stock: {Quantity}";
        }
    }
}