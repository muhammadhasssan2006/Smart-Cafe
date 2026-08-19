using System;

class MainMenu
{
    private LoginManager loginManager = new LoginManager();
    private MenuManager menuManager = new MenuManager();
    private OrderManager orderManager;

    private PaymentManager paymentManager = new PaymentManager();
    private ReportManager reportManager;

    public MainMenu()
    {
        // Use the same managers throughout the project
        orderManager = new OrderManager(menuManager);

        reportManager = new ReportManager(
            orderManager.Orders,
            paymentManager.Payments
        );
    }

    public void ShowMainMenu()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("   SMART CAFE MANAGEMENT SYSTEM");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Customer Menu");
            Console.WriteLine("3. Exit");
            Console.WriteLine("======================================");

            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                // Login for Admin and Cashier
                case 1:

                    Console.Write("\nEnter Username: ");
                    string username = Console.ReadLine() ?? "";

                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine() ?? "";

                    User loggedInUser = loginManager.Login(username, password);

                    if (loggedInUser != null)
                    {
                        if (loggedInUser.Role == "Admin")
                        {
                            // Admin gets menu management and reports
                            AdminMenu adminMenu =
                                new AdminMenu(menuManager, reportManager);

                            adminMenu.ShowMenu();
                        }
                        else if (loggedInUser.Role == "Cashier")
                        {
                            // Cashier handles existing orders
                            CashierMenu cashierMenu =
                                new CashierMenu(orderManager);

                            cashierMenu.ShowMenu();
                        }
                    }

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;

                // Customer can browse menu and place orders
                case 2:

                    CustomerMenu customerMenu =
                        new CustomerMenu(menuManager, orderManager);

                    customerMenu.ShowMenu();
                    break;

                // Exit the application
                case 3:

                    Console.WriteLine("\nThank You For Using Smart Cafe.");
                    return;

                default:

                    Console.WriteLine("\nInvalid Choice!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}