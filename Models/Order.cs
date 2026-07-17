using System;
using System.Collections.Generic;

class Order
{
    // Attributes
    private int orderId;
    private string customerName = "";
    private string orderType = "";
    private string status = "";
    private List<OrderItem> orderItems = new List<OrderItem>();

    // Constructor
    public Order(int orderId, string customerName, string orderType)
    {
        this.orderId = orderId;
        this.customerName = customerName;
        this.orderType = orderType;
        status = "Pending";
    }

    // Properties
    public int OrderId
    {
        get { return orderId; }
        set { orderId = value; }
    }

    public string CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }

    public string OrderType
    {
        get { return orderType; }
        set { orderType = value; }
    }

    public string Status
    {
        get { return status; }
        set { status = value; }
    }

    public List<OrderItem> OrderItems
    {
        get { return orderItems; }
    }

    // Read Only Property
    public double TotalAmount
    {
        get
        {
            double total = 0;

            foreach (OrderItem item in orderItems)
            {
                total += item.SubTotal;
            }

            return total;
        }
    }

    // Add Item
    public void AddItem(OrderItem item)
    {
        orderItems.Add(item);
    }

    // Remove Item
    public void RemoveItem(OrderItem item)
    {
        orderItems.Remove(item);
    }

    // Display Order
    public void DisplayOrder()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("Order ID      : " + OrderId);
        Console.WriteLine("Customer Name : " + CustomerName);
        Console.WriteLine("Order Type    : " + OrderType);
        Console.WriteLine("Status        : " + Status);
        Console.WriteLine("========================================");

        foreach (OrderItem item in orderItems)
        {
            item.DisplayOrderItem();
        }

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Total Amount : Rs. " + TotalAmount);
        Console.WriteLine("========================================");
    }
}