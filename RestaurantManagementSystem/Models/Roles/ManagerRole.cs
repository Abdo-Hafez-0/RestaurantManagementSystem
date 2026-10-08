using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models.Roles
{
    public class ManagerRole : EmployeeRole
    {
        public override string GetRoleName() => "Manager";

        public override void PerformDuty() => Console.WriteLine("Manager is managing the restaurant.");
        
    }
}
