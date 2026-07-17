using System;

class OrderItem
{
    // Attributes
    private MenuItem menuItem;
    private int quantity;

    // Constructor
    public OrderItem(MenuItem menuItem, int quantity)
    {
        this.menuItem = menuItem;
        this.quantity = quantity;
    }

    // Properties
    public MenuItem MenuItem
    {
        get { return menuItem; }
        set { menuItem = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    // Read Only Property
    public double SubTotal
    {
        get { return menuItem.Price * quantity; }
    }

    // Method
    public void DisplayOrderItem()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Item Name : " + menuItem.ItemName);
        Console.WriteLine("Price     : Rs. " + menuItem.Price);
        Console.WriteLine("Quantity  : " + quantity);
        Console.WriteLine("Subtotal  : Rs. " + SubTotal);
        Console.WriteLine("--------------------------------------");
    }
}