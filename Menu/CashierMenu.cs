using System;

class CashierMenu
{
    public void ShowMenu()
    {
        Console.Clear();

        Console.WriteLine("================================");
        Console.WriteLine("        CASHIER PANEL");
        Console.WriteLine("================================");

        Console.WriteLine("1. New Order");
        Console.WriteLine("2. Generate Bill");
        Console.WriteLine("3. Take Payment");
        Console.WriteLine("4. Logout");

        Console.Write("\nSelect Option: ");
    }
}