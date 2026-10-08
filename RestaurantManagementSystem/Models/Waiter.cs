using RestaurantManagementSystem.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public class Waiter : Employee
    {
        public Waiter(int id, string name) : base(id, name, new WaiterRole())
        {
        }

        public void ServeOrder() => Role.PerformDuty();

        


    }
}
