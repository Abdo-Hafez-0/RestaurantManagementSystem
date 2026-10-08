using RestaurantManagementSystem.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public class Manager : Employee
    {
        public Manager(int id, string name) : base(id, name, new ManagerRole())
        {
        }

        public void ManageRestaurant() => Role.PerformDuty();

        

    }
}
