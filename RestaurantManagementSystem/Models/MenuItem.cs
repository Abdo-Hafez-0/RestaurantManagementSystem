using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public bool IsAvailable { get; private set; }
        public MenuCategory? Category { get; set; }


        public MenuItem(string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");
            if (price < 0)
                throw new ArgumentException("Price cannot be negative.");
            
            Name = name;
            Price = price;
            IsAvailable = true;
        }

        public void ChangePrice(decimal newPrice)
        {
            if (newPrice < 0)
                throw new ArgumentException("Price cannot be negative.");
            Price = newPrice;
        }

        public void Enable() => IsAvailable = true;
        public void Disable() => IsAvailable = false;

    }
}
