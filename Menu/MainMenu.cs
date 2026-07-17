using System;

class MainMenu
{
    private LoginManager loginManager = new LoginManager();
    private MenuManager menuManager = new MenuManager();
    private OrderManager orderManager;

    public MainMenu()
    {
        orderManager = new OrderManager(menuManager);
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
            Console.WriteLine("2. Exit");
            Console.WriteLine("======================================");

            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Console.Write("\nEnter Username: ");
                    string username = Console.ReadLine();

                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();

                    User loggedInUser = loginManager.Login(username, password);

                    if (loggedInUser != null)
                    {
                        if (loggedInUser.Role == "Admin")
                        {
                            AdminMenu adminMenu = new AdminMenu(menuManager);
                            adminMenu.ShowMenu();
                        }
                        else if (loggedInUser.Role == "Cashier")
                        {
                            CashierMenu cashierMenu = new CashierMenu(orderManager);
                            cashierMenu.ShowMenu();
                        }
                    }

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;

                case 2:
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