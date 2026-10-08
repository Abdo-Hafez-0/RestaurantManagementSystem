using RestaurantManagementSystem.Contracts;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Services;

namespace RestaurantManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================
            // 1. Create domain objects
            // =========================

            var waiter = new Waiter(1, "Ali");
            var cashier = new Cashier(2, "Mohammed");
            var manager = new Manager(3, "Amr");

            var restaurant = new Restaurant();

            var category = new MenuCategory("Main Course");
            var menuItem = new MenuItem("Burger", 250m)
            {
                MenuCategory = category
            };

            var order = new Order
            {
                Waiter = waiter
            };

            var orderItem = new OrderItem(menuItem, 2);


            // =========================
            // 2. Create services
            // =========================

            var restaurantService = new RestaurantService();
            var orderService = new OrderService();
            var employeeService = new EmployeeService();


            // =========================
            // 3. Restaurant operations
            // =========================

            restaurantService.AddEmployee(restaurant, waiter);
            restaurantService.AddEmployee(restaurant, cashier);
            restaurantService.AddEmployee(restaurant, manager);


            // =========================
            // 4. Employee operations
            // =========================

            employeeService.DisplayEmployees(restaurant.Employees);


            // =========================
            // 5. Order operations
            // =========================

            orderService.AddItem(order, orderItem);

            Console.WriteLine($"Order Items: {order.Items.Count}");


            // =========================
            // 6. Existing specialized behavior
            // =========================

            waiter.ServeOrder();
            cashier.ProcessPayment(500m);
            manager.ManageRestaurant();


            // =========================
            // 7. Interface demonstration
            // =========================

            IPayable payable = cashier;
            payable.ProcessPayment(300m);

            IOrderService orderServiceInterface = order;
            orderServiceInterface.AddItem(
                new OrderItem(menuItem, 1)
            );


            // =========================
            // 8. Removal demonstration
            // =========================

            orderService.RemoveItem(order, orderItem);

            restaurantService.RemoveEmployee(restaurant, waiter);
        }
    }
}