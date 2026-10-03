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
        public RestaurantTable? Table { get; set; }
        public Waiter? Waiter { get; set; }
        public List<OrderItem> Items { get; set; } = new();
    }
}
