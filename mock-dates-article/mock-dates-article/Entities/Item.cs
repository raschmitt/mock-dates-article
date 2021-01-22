using System;

namespace mock_dates_article
{
    public class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
            PurchaseTime = DateTime.Now;
        }
    
        public string Name { get; protected set; }
        public double Price { get; protected set; }
        public DateTime PurchaseTime { get; protected set; }
    }
}