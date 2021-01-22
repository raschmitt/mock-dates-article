using System;
using System.Collections.Generic;
using System.Linq;

namespace mock_dates_article
{
    public class Order
    {
        public TimeSpan _purchaseSpanLimit = new TimeSpan(2, 0, 0);

        public Guid Id { get; }
        public List<Item> Items { get; }
    
        public Order()
        {
            Id = Guid.NewGuid();
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            var firstItemPurchasedAt = Items.OrderBy(i => i.PurchaseTime).FirstOrDefault()?.PurchaseTime;
            var totalPurchaseSpan = item.PurchaseTime - firstItemPurchasedAt;

            if (firstItemPurchasedAt == null || totalPurchaseSpan <= _purchaseSpanLimit)
                Items.Add(item);
        }
    }     
}