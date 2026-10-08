using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public MenuItem? MenuItem { get; set; }
        public int Quantity { get; private set; }

        public OrderItem(MenuItem menuItem, int quantity)
        {
            if (menuItem is null)
                throw new ArgumentNullException(nameof(menuItem));
            
            if (quantity <= 0)
                throw new ArgumentException(nameof(quantity)," must be greater thena 0");
            
            MenuItem = menuItem;
            Quantity = quantity;
        }
        public OrderItem(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity cannot be empty.");

            Quantity = quantity;
        }
        public OrderItem(OrderItem other)
        {
            if (other is null)
                throw new ArgumentNullException(nameof(other));
            Id = other.Id;
            
            if (other.MenuItem is null)
                throw new ArgumentNullException(nameof(other.MenuItem));

            MenuItem = new MenuItem(other.MenuItem.Name, other.MenuItem.Price);
            Quantity = other.Quantity;
        }
        public void IncreaseQuantity(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount cannot be 0 or less");

            Quantity += amount;
        }
        public void DecreaseQuantity(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount cannot be 0 or less");
            if (Quantity - amount <= 0)
                throw new ArgumentException("Not enough quantity.");

            Quantity -= amount;
        }

    }
}
