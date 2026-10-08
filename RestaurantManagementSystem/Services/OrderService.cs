using RestaurantManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Services
{
    public class OrderService
    {
        public void AddItem(Order order, OrderItem orderItem)
        {
            if (order is null)
                throw new ArgumentNullException("Order cannot be null.");
            if (orderItem is null)
                throw new ArgumentNullException("Order item cannot be null.");
            order.AddItem(orderItem);
        }
        public void RemoveItem(Order order, OrderItem orderItem)
        {
            if (order is null)
                throw new ArgumentNullException("Order cannot be null.");
            if (orderItem is null)
                throw new ArgumentNullException("Order item cannot be null.");
            order.RemoveItem(orderItem);
        }
    }
}
