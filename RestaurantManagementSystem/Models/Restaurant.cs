

namespace RestaurantManagementSystem.Models
{
    public class Restaurant
    {
        private readonly List<Employee> _employees = new();
        public IReadOnlyList<Employee> Employees => _employees.AsReadOnly();

        public void AddEmployee(Employee newEmp)
        {
            if (newEmp is null)
                throw new ArgumentNullException(nameof(newEmp), "Employee cannot be null.");
            _employees.Add(newEmp);
        }
        public void RemoveEmployee(Employee newEmp)
        {
            if (newEmp is null)
                throw new ArgumentNullException(nameof(newEmp), "Employee cannot be null.");
            if (!_employees.Remove(newEmp))
                throw new ArgumentException("Employee not found.");
        }
    }
}
