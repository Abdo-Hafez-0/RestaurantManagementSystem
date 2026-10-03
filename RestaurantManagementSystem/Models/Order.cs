using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public RestaurantTable Table { get; set; } = null!;
        public Waiter? Waiter { get; set; }
        private readonly List<OrderItem> _items = new();
        public IReadOnlyList<OrderItem> Items => _items.AsReadOnly();


        public void AddItem(OrderItem item)
        {
            if (item is null)
                throw new ArgumentException("Item cannot be empty.");
            _items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            if (!Items.Contains(item))
                throw new ArgumentException("Item not found.");
            _items.Remove(item);
        }
    }
}
