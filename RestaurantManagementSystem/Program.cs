using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Order o1 = new Order();
            Order o2 = new Order();

            Console.WriteLine(o1.Id);
            Console.WriteLine(o2.Id);

            Console.WriteLine(Order.TotalOrdersCreated);
            Console.WriteLine(RestaurantSettings.CalculateTax(100));
            Console.WriteLine(RestaurantSettings.CalculateServiceCharge(100));
        }
    }
}
