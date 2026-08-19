using System;

class AdminMenu
{
    private MenuManager menuManager;
    private ReportManager reportManager;

    // Get menu and report managers from the main menu
    public AdminMenu(
        MenuManager menuManager,
        ReportManager reportManager)
    {
        this.menuManager = menuManager;
        this.reportManager = reportManager;
    }

    // Show admin panel
    public void ShowMenu()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("            ADMIN PANEL");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Add Menu Item");
            Console.WriteLine("2. View Menu");
            Console.WriteLine("3. Search Menu Item");
            Console.WriteLine("4. Update Menu Item");
            Console.WriteLine("5. Delete Menu Item");
            Console.WriteLine("6. View Reports");
            Console.WriteLine("7. Logout");
            Console.WriteLine("======================================");

            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                // Add a new item to the cafe menu
                case 1:
                    menuManager.AddMenuItem();
                    break;

                // Display all menu items
                case 2:
                    menuManager.ViewMenuItems();
                    break;

                // Search for a menu item
                case 3:
                    menuManager.SearchMenuItem();
                    break;

                // Update an existing menu item
                case 4:
                    menuManager.UpdateMenuItem();
                    break;

                // Delete a menu item
                case 5:
                    menuManager.DeleteMenuItem();
                    break;

                // Open the reports section
                case 6:
                    ShowReportsMenu();
                    break;

                // Exit the admin panel
                case 7:
                    Console.WriteLine("\nLogging Out...");
                    Console.ReadKey();
                    return;

                default:
                    Console.WriteLine("\nInvalid Choice!");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // Show different report options
    private void ShowReportsMenu()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("             REPORTS");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Summary Report");
            Console.WriteLine("2. Order Report");
            Console.WriteLine("3. Payment Report");
            Console.WriteLine("4. Back");
            Console.WriteLine("======================================");

            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                // Show overall cafe information
                case 1:
                    reportManager.ShowReport();
                    break;

                // Show all orders
                case 2:
                    reportManager.ViewOrderReport();
                    break;

                // Show payment history
                case 3:
                    reportManager.ViewPaymentReport();
                    break;

                // Return to admin panel
                case 4:
                    return;

                default:
                    Console.WriteLine("\nInvalid Choice!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}