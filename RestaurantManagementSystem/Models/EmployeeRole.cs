using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public abstract class EmployeeRole
    {
        public abstract string GetRoleName();
        public abstract void PerformDuty();
    }
}
