using System;
using System.Collections.Generic;

class MenuManager
{
    private List<MenuItem> menuItems = new List<MenuItem>();
    public List<MenuItem> MenuItems
    {
        get { return menuItems; }
    }

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

    // Search Menu Item
    public void SearchMenuItem()
    {
        Console.Clear();

        Console.Write("Enter Item ID To Search: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach (MenuItem item in menuItems)
        {
            if (item.ItemId == searchId)
            {
                item.DisplayMenuItem();
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nItem Not Found!");
        }

        Console.ReadKey();
    }

    // Update Menu Item
    public void UpdateMenuItem()
    {
        Console.Clear();

        Console.Write("Enter Item ID To Update: ");
        int updateId = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach (MenuItem item in menuItems)
        {
            if (item.ItemId == updateId)
            {
                Console.Write("Enter New Item Name: ");
                item.ItemName = Console.ReadLine();

                Console.Write("Enter New Category: ");
                item.Category = Console.ReadLine();

                Console.Write("Enter New Price: ");
                item.Price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Is Item Available? (Yes/No): ");
                string availability = Console.ReadLine().ToLower();

                if (availability == "yes" || availability == "y")
                {
                    item.IsAvailable = true;
                }
                else
                {
                    item.IsAvailable = false;
                }

                Console.WriteLine("\nItem Updated Successfully!");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nItem Not Found!");
        }

        Console.ReadKey();
    }

    // Delete Menu Item
    public void DeleteMenuItem()
    {
        Console.Clear();

        Console.Write("Enter Item ID To Delete: ");
        int deleteId = Convert.ToInt32(Console.ReadLine());

        MenuItem itemToDelete = null;

        foreach (MenuItem item in menuItems)
        {
            if (item.ItemId == deleteId)
            {
                itemToDelete = item;
                break;
            }
        }

        if (itemToDelete != null)
        {
            menuItems.Remove(itemToDelete);
            Console.WriteLine("\nItem Deleted Successfully!");
        }
        else
        {
            Console.WriteLine("\nItem Not Found!");
        }

        Console.ReadKey();
    }
}