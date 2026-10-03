using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public RestaurantTable Table { get; set; }
        public Waiter Waiter { get; set; }
        public OrderItem Item { get; set; }
    }
}
