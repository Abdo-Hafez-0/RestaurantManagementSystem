
namespace RestaurantManagementSystem.Models
{
    public abstract class Employee
    {
        public int Id { get; private set; }
        public string? Name { get; private set; }

        public Employee(int id, string name)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than 0.");
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name cannot be empty.");

            Id = id;
            Name = name;
        }
        protected string? GetEmployeeName() => Name;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");

        }
    }
}
