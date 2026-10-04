using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public class Order
    {
        public int Id { get; private set; }
        public DateTime OrderDate { get; set; }
        public RestaurantTable Table { get; set; } = null!;
        public Waiter? Waiter { get; set; }

        private readonly List<OrderItem> _items = new();
        public IReadOnlyList<OrderItem> Items => _items.AsReadOnly();

        private static int _totalOrdersCreated;

        private static int _nextId;
        public static int TotalOrdersCreated => _totalOrdersCreated;

        static Order()
        {
            _nextId = 1;
            _totalOrdersCreated = 0;
        }

        public Order()
        {
            Id = _nextId++;
            _totalOrdersCreated++;
        }
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
