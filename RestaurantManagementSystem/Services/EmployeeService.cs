using RestaurantManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Services
{
    public class EmployeeService
    {
        public void DisplayEmployees(IEnumerable<Employee> employees)
        {
            if (employees is null)
                throw new ArgumentNullException(nameof(employees));
            foreach (var emp in employees)
            {
                emp.DisplayInfo();
            }
        }
    }
}
