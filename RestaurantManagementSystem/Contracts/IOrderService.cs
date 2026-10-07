using RestaurantManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Contracts
{
    public interface IOrderService
    {
        void AddItem(OrderItem item);
        void RemoveItem(OrderItem item);
    }
}
