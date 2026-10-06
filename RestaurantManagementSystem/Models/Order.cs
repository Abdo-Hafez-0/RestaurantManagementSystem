
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

        public Order(Order other)
        {
            if (other is null)
                throw new ArgumentNullException("Order cannot be empty.");
            
            Id = other.Id;
            OrderDate = other.OrderDate;
            if(other.Table is not null)
                Table = new RestaurantTable(other.Table.TableNumber, other.Table.Capacity);
            if (other.Waiter is not null) 
                Waiter = new Waiter(other.Waiter.Id, other.Waiter.Name);
            foreach (var item in other.Items)
            {
                _items.Add(new OrderItem(item.Quantity));
            }

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
            if (!_items.Remove(item))
                throw new ArgumentException("Item not found.");
        }

        public Order CloneForModification()
        {
            return new Order(this);
        }
    }
}
