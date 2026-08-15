using System;

class Bill
{
    // Properties
    public int BillId { get; set; }

    public Order Order { get; set; }

    public double TotalAmount { get; set; }

    public double Tax { get; set; }

    public double Discount { get; set; }

    public double GrandTotal { get; set; }


    // Constructor
    public Bill(int billId, Order order, double tax, double discount)
    {
        BillId = billId;
        Order = order;

        TotalAmount = order.TotalAmount;

        Tax = tax;
        Discount = discount;

        GrandTotal = TotalAmount + Tax - Discount;
    }


    // Display Bill
    public void DisplayBill()
    {
        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("              SMART CAFE");
        Console.WriteLine("               FINAL BILL");
        Console.WriteLine("========================================");

        Console.WriteLine("Bill ID       : " + BillId);
        Console.WriteLine("Order ID      : " + Order.OrderId);
        Console.WriteLine("Customer Name : " + Order.CustomerName);
        Console.WriteLine("Order Type    : " + Order.OrderType);

        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Total Amount  : Rs. " + TotalAmount);
        Console.WriteLine("Tax           : Rs. " + Tax);
        Console.WriteLine("Discount      : Rs. " + Discount);

        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Grand Total   : Rs. " + GrandTotal);

        Console.WriteLine("========================================");
        Console.WriteLine("        Thank You! Visit Again.");
        Console.WriteLine("========================================");
    }
}