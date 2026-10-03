using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public Ingredient? Ingredient { get; set; }
        public double Quantity { get; set; }
    }
}
