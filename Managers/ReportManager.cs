using System;
using System.Collections.Generic;

class ReportManager
{
    private List<Order> orders;
    private List<Payment> payments;

    // Get existing orders and payments from the system
    public ReportManager(List<Order> orders, List<Payment> payments)
    {
        this.orders = orders;
        this.payments = payments;
    }

    // Show a summary of cafe activity
    public void ShowReport()
    {
        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          SMART CAFE REPORT");
        Console.WriteLine("========================================");

        Console.WriteLine("Total Orders    : " + orders.Count);
        Console.WriteLine("Total Payments  : " + payments.Count);

        int pendingOrders = 0;
        int cancelledOrders = 0;
        int completedOrders = 0;

        // Count orders according to their current status
        foreach (Order order in orders)
        {
            if (order.Status == "Pending")
            {
                pendingOrders++;
            }
            else if (order.Status == "Cancelled")
            {
                cancelledOrders++;
            }
            else if (order.Status == "Completed")
            {
                completedOrders++;
            }
        }

        Console.WriteLine("Pending Orders  : " + pendingOrders);
        Console.WriteLine("Cancelled Orders: " + cancelledOrders);
        Console.WriteLine("Completed Orders: " + completedOrders);

        double totalSales = 0;

        // Calculate total sales from successful payments
        foreach (Payment payment in payments)
        {
            if (payment.PaymentStatus == "Successful")
            {
                totalSales += payment.BillAmount;
            }
        }

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Total Sales     : Rs. " + totalSales);
        Console.WriteLine("========================================");

        Console.ReadKey();
    }

    // Display all orders in the report
    public void ViewOrderReport()
    {
        Console.Clear();

        Console.WriteLine("========== ORDER REPORT ==========\n");

        if (orders.Count == 0)
        {
            Console.WriteLine("No Orders Available.");
        }
        else
        {
            foreach (Order order in orders)
            {
                order.DisplayOrder();
            }
        }

        Console.ReadKey();
    }

    // Display all successful payments
    public void ViewPaymentReport()
    {
        Console.Clear();

        Console.WriteLine("========== PAYMENT REPORT ==========\n");

        if (payments.Count == 0)
        {
            Console.WriteLine("No Payments Available.");
        }
        else
        {
            foreach (Payment payment in payments)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Payment ID     : " + payment.PaymentId);
                Console.WriteLine("Bill ID        : " + payment.BillId);
                Console.WriteLine("Bill Amount    : Rs. " + payment.BillAmount);
                Console.WriteLine("Paid Amount    : Rs. " + payment.PaidAmount);
                Console.WriteLine("Change         : Rs. " + payment.ChangeAmount);
                Console.WriteLine("Status         : " + payment.PaymentStatus);
            }

            Console.WriteLine("----------------------------------------");
        }

        Console.ReadKey();
    }
}