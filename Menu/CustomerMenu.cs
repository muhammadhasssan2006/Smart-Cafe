using System;

class CustomerMenu
{
    private MenuManager menuManager;
    private OrderManager orderManager;

    // Use the existing menu and order managers
    public CustomerMenu(
        MenuManager menuManager,
        OrderManager orderManager)
    {
        this.menuManager = menuManager;
        this.orderManager = orderManager;
    }

    // Show customer menu
    public void ShowMenu()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("          CUSTOMER MENU");
            Console.WriteLine("======================================");
            Console.WriteLine("1. View Menu");
            Console.WriteLine("2. Place Order");
            Console.WriteLine("3. Back");
            Console.WriteLine("======================================");

            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                // Customer can view available menu items
                case 1:
                    menuManager.ViewMenuItems();
                    break;

                // Customer can place a new order
                case 2:
                    orderManager.CreateCustomerOrder();
                    break;

                // Return to the main menu
                case 3:
                    return;

                default:
                    Console.WriteLine("\nInvalid Choice!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}