using System;

class AdminMenu
{
    private MenuManager menuManager = new MenuManager();

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
            Console.WriteLine("6. Logout");
            Console.WriteLine("======================================");

            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    menuManager.AddMenuItem();
                    break;

                case 2:
                    menuManager.ViewMenuItems();
                    break;

                case 3:
                    menuManager.SearchMenuItem();
                    break;

                case 4:
                    menuManager.UpdateMenuItem();
                    break;

                case 5:
                    menuManager.DeleteMenuItem();
                    break;

                case 6:
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
}