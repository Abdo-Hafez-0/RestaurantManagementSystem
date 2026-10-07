using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public class Waiter : Employee
    {
        public Waiter(int id, string name) : base(id, name)
        {
        }

        public void ServeOrder() => Console.WriteLine($"{GetEmployeeName()} is serving an order.");

        

        public override string GetRole() => "Waiter";

    }
}
