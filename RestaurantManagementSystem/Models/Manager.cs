using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public class Manager : Employee
    {
        public Manager(int id, string name) : base(id, name)
        {
        }

        public void ManageRestaurant() => Console.WriteLine($"{GetEmployeeName()} is managing the restaurant.");

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: Manager");
        }
    }
}
