using RestaurantManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Services
{
    public class RestaurantService
    {
        public void AddEmployee(Restaurant restaurant, Employee employee)
        {
            if (restaurant is null)
                throw new ArgumentNullException("Restaurant cannot be null.");
            if (employee is null)
                throw new ArgumentNullException("Employee cannot be null.");
            restaurant.AddEmployee(employee);
        }
        public void RemoveEmployee(Restaurant restaurant, Employee employee)
        {
            if (restaurant is null)
                throw new ArgumentNullException("Restaurant cannot be null.");
            if (employee is null)
                throw new ArgumentNullException("Employee cannot be null.");
            restaurant.RemoveEmployee(employee);
        }
    }
}
