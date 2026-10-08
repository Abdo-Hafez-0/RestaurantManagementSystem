using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models.Roles
{
    public class CashierRole : EmployeeRole
    {
        public override string GetRoleName() => "Cashier";
        public override void PerformDuty() => Console.WriteLine("Cashier is processing a payment.");
    }
}
