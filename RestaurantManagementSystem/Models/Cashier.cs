using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public class Cashier : Employee
    {
        public Cashier(int id, string name) : base(id, name)
        {
        }

        public void ProcessPayment() => Console.WriteLine($"{GetEmployeeName()} is processing a payment.");
    }
}
