using System;

class AdminMenu
{
    public void ShowMenu()
    {
        Console.Clear();

        Console.WriteLine("================================");
        Console.WriteLine("         ADMIN PANEL");
        Console.WriteLine("================================");

        Console.WriteLine("1. Menu Management");
        Console.WriteLine("2. Employee Management");
        Console.WriteLine("3. Reports");
        Console.WriteLine("4. Logout");

        Console.Write("\nSelect Option: ");
    }
}