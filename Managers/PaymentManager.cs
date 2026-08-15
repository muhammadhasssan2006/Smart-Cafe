using System;
using System.Collections.Generic;

class PaymentManager
{
    private List<Payment> payments = new List<Payment>();

    // Take Payment
    public void TakePayment(Bill bill)
    {
        Console.Clear();

        Console.WriteLine("========== TAKE PAYMENT ==========");

        Console.Write("Enter Payment ID: ");
        int paymentId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nBill Amount: Rs. " + bill.GrandTotal);

        Console.Write("Enter Paid Amount: ");
        double paidAmount = Convert.ToDouble(Console.ReadLine());

        Payment payment = new Payment(
            paymentId,
            bill.BillId,
            bill.GrandTotal,
            paidAmount
        );

        payments.Add(payment);

        payment.DisplayPayment();

        Console.ReadKey();
    }

    // View All Payments
    public void ViewPayments()
    {
        Console.Clear();

        Console.WriteLine("========== PAYMENT HISTORY ==========");

        if (payments.Count == 0)
        {
            Console.WriteLine("\nNo Payments Available.");
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
        }

        Console.WriteLine("----------------------------------------");

        Console.ReadKey();
    }
}