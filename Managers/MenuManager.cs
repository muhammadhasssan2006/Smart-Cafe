using System;
using System.Collections.Generic;

class MenuManager
{
    private List<MenuItem> menuItems = new List<MenuItem>();

    // Gives other parts of the project access to the existing menu
    public List<MenuItem> MenuItems
    {
        get { return menuItems; }
    }

    // Add some default items when the cafe starts
    public MenuManager()
    {
        menuItems.Add(new MenuItem(
            1,
            "Burger",
            "Fast Food",
            450,
            true
        ));

        menuItems.Add(new MenuItem(
            2,
            "Pizza",
            "Fast Food",
            800,
            true
        ));

        menuItems.Add(new MenuItem(
            3,
            "Fries",
            "Snacks",
            150,
            true
        ));

        menuItems.Add(new MenuItem(
            4,
            "Chicken Roll",
            "Fast Food",
            250,
            true
        ));

        menuItems.Add(new MenuItem(
            5,
            "Cold Drink",
            "Beverages",
            100,
            true
        ));
    }

    // Add a new menu item
    public void AddMenuItem()
    {
        Console.Clear();

        Console.WriteLine("========== ADD MENU ITEM ==========");

        Console.Write("Enter Item ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        // Check if the ID already exists
        foreach (MenuItem item in menuItems)
        {
            if (item.ItemId == id)
            {
                Console.WriteLine("\nItem ID already exists!");
                Console.ReadKey();
                return;
            }
        }

        Console.Write("Enter Item Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter Category: ");
        string category = Console.ReadLine() ?? "";

        Console.Write("Enter Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        MenuItem newItem = new MenuItem(
            id,
            name,
            category,
            price,
            true
        );

        menuItems.Add(newItem);

        Console.WriteLine("\nMenu Item Added Successfully!");
        Console.ReadKey();
    }

    // Display all menu items
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

    // Search for a menu item using its ID
    public void SearchMenuItem()
    {
        Console.Clear();

        Console.WriteLine("========== SEARCH MENU ITEM ==========\n");

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

    // Update an existing menu item
    public void UpdateMenuItem()
    {
        Console.Clear();

        Console.WriteLine("========== UPDATE MENU ITEM ==========\n");

        Console.Write("Enter Item ID To Update: ");
        int updateId = Convert.ToInt32(Console.ReadLine());

        MenuItem selectedItem = null;

        foreach (MenuItem item in menuItems)
        {
            if (item.ItemId == updateId)
            {
                selectedItem = item;
                break;
            }
        }

        if (selectedItem == null)
        {
            Console.WriteLine("\nItem Not Found!");
            Console.ReadKey();
            return;
        }

        Console.Write("Enter New Item Name: ");
        selectedItem.ItemName = Console.ReadLine() ?? "";

        Console.Write("Enter New Category: ");
        selectedItem.Category = Console.ReadLine() ?? "";

        Console.Write("Enter New Price: ");
        selectedItem.Price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Is Item Available? (Yes/No): ");
        string availability = (Console.ReadLine() ?? "").ToLower();

        if (availability == "yes" || availability == "y")
        {
            selectedItem.IsAvailable = true;
        }
        else if (availability == "no" || availability == "n")
        {
            selectedItem.IsAvailable = false;
        }
        else
        {
            Console.WriteLine("\nInvalid availability input.");
            Console.WriteLine("Availability remains unchanged.");
        }

        Console.WriteLine("\nItem Updated Successfully!");
        Console.ReadKey();
    }

    // Delete an existing menu item
    public void DeleteMenuItem()
    {
        Console.Clear();

        Console.WriteLine("========== DELETE MENU ITEM ==========\n");

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