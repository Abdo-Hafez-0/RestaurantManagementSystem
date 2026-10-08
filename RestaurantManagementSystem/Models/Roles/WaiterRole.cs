using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models.Roles
{
    public class WaiterRole : EmployeeRole
    {
        public override string GetRoleName() => "Waiter";

        public override void PerformDuty() => Console.WriteLine("Waiter is serving an order.");
    }
}
