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

            Waiter w1 = new Waiter(1,"Ahmed");
            o1.Waiter = w1;

            MenuItem mi1 = new MenuItem("name", 50m);
            MenuCategory mc1 = new MenuCategory();
            mi1.MenuCategory = mc1;

            Restaurant r1 = new Restaurant();
            r1.AddEmployee(w1);

            OrderItem oi1 = new OrderItem(5);
            o1.AddItem(oi1);

            Console.WriteLine(w1);
            Console.WriteLine(o1);
            Console.WriteLine(mi1);
            Console.WriteLine(mc1);
            Console.WriteLine(r1);
            Console.WriteLine(oi1);


            Waiter w2 = new Waiter(2, "Ali");
            Cashier c2 = new Cashier(3, "Mohammed");
            Manager m2 = new Manager(4, "Amr");

            w2.DisplayInfo();
            c2.DisplayInfo();
            m2.DisplayInfo();

            w2.ServeOrder();
            c2.ProcessPayment();
            m2.ManageRestaurant();

            r1.AddEmployee(w2);
            r1.AddEmployee(c2);
            r1.AddEmployee(m2);

            foreach (var item in r1.Employees)
            {
                Console.WriteLine(item);
            }

        }
    }
}
