using System;

class MenuItem
{
    // Attributes
    private int itemId;
    private string itemName = "";
    private string category = "";
    private double price;
    private bool isAvailable;

    // Constructor
    public MenuItem(int itemId, string itemName, string category, double price, bool isAvailable)
    {
        this.itemId = itemId;
        this.itemName = itemName;
        this.category = category;
        this.price = price;
        this.isAvailable = isAvailable;
    }

    // Properties
    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string Category
    {
        get { return category; }
        set { category = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public bool IsAvailable
    {
        get { return isAvailable; }
        set { isAvailable = value; }
    }

    // Method
    public void DisplayMenuItem()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("Item ID      : " + ItemId);
        Console.WriteLine("Item Name    : " + ItemName);
        Console.WriteLine("Category     : " + Category);
        Console.WriteLine("Price        : Rs. " + Price);
        Console.WriteLine("Availability : " + (IsAvailable ? "Available" : "Not Available"));
        Console.WriteLine("==================================");
    }
}