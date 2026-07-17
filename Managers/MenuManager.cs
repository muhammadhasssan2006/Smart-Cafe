using System;
using System.Collections.Generic;

class MenuManager
{
    private List<MenuItem> menuItems = new List<MenuItem>();

    // Add New Menu Item
    public void AddMenuItem()
    {
        Console.Clear();
        Console.WriteLine("========== Add Menu Item ==========");

        Console.Write("Enter Item ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Item Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Category: ");
        string category = Console.ReadLine();

        Console.Write("Enter Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        MenuItem item = new MenuItem(id, name, category, price, true);

        menuItems.Add(item);

        Console.WriteLine("\nMenu Item Added Successfully!");
        Console.ReadKey();
    }

    // View All Menu Items
    public void ViewMenuItems()
    {
        Console.Clear();
        Console.WriteLine("========== MENU ==========\n");

        if (menuItems.Count == 0)
        {
            Console.WriteLine("No Menu Items Found.");
        }
        else
        {
            foreach (MenuItem item in menuItems)
            {
                item.DisplayMenuItem();
            }
        }

        Console.ReadKey();
    }
}