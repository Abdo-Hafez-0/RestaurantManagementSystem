
namespace RestaurantManagementSystem.Models
{
    public abstract class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        protected EmployeeRole Role { get; }
        public Employee(int id, string name, EmployeeRole role)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than 0.");
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name cannot be empty.");
            if (role is null)
                throw new ArgumentNullException(nameof(role));
            Id = id;
            Name = name;
            Role = role;
        }
        public string GetRole() => Role.GetRoleName();
        protected string? GetEmployeeName() => Name;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Role: {GetRole()}");

        }
    }
}
