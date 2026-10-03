using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public class RestaurantTable
    {
        public int Id { get; set; }
        public int TableNumber { get; private set; }
        public int Capacity { get; private set; }
        public bool IsAvailable { get; private set; }

        public RestaurantTable(int tableNumber, int capacity)
        {
            if (tableNumber <= 0)
                throw new ArgumentException("Table number must greater than 0.");
            if (capacity <= 0)
                throw new ArgumentException("Capacity must greater than 0.");

            TableNumber = tableNumber;
            Capacity = capacity;
            IsAvailable = true;
        }

        public void Reserve() => IsAvailable = false;
        public void Release() => IsAvailable = true;
    }
}
