using System;

class BillingManager
{
    public void GenerateBill(Order order)
    {
        Console.Clear();

        Console.WriteLine("========== GENERATE BILL ==========");

        Console.Write("Enter Bill ID: ");
        int billId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Tax Amount: ");
        double tax = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Discount Amount: ");
        double discount = Convert.ToDouble(Console.ReadLine());

        Bill bill = new Bill(billId, order, tax, discount);

        Console.WriteLine("\nBill Generated Successfully!");

        Console.ReadKey();

        bill.DisplayBill();

        Console.ReadKey();
    }

    // Bill Generate-----
    public void GenerateBillByOrderId(OrderManager orderManager)
    {
        Console.Clear();

        Console.WriteLine("========== GENERATE BILL ==========");

        Console.Write("Enter Order ID: ");
        int orderId = Convert.ToInt32(Console.ReadLine());

        Order order = orderManager.GetOrderById(orderId);

        if (order == null)
        {
            Console.WriteLine("\nOrder Not Found.");
            Console.ReadKey();
            return;
        }

        GenerateBill(order);
    }
}

