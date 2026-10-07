using RestaurantManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public class Cashier : Employee, IPayable
    {
        public Cashier(int id, string name) : base(id, name)
        {
        }

        public void ProcessPayment(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be greater than 0");
            Console.WriteLine("Processing Payment.");
        }

        public override string GetRole() => "Cashier";
    }
}
