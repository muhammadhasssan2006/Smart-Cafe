using System;

class Payment
{
    public int PaymentId { get; set; }

    public int BillId { get; set; }

    public double BillAmount { get; set; }

    public double PaidAmount { get; set; }

    public double ChangeAmount { get; set; }

    public string PaymentStatus { get; set; }


    public Payment(
        int paymentId,
        int billId,
        double billAmount,
        double paidAmount)
    {
        PaymentId = paymentId;
        BillId = billId;
        BillAmount = billAmount;
        PaidAmount = paidAmount;

        if (paidAmount >= billAmount)
        {
            ChangeAmount = paidAmount - billAmount;
            PaymentStatus = "Successful";
        }
        else
        {
            ChangeAmount = 0;
            PaymentStatus = "Insufficient Amount";
        }
    }


    public void DisplayPayment()
    {
        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          SMART CAFE PAYMENT");
        Console.WriteLine("========================================");

        Console.WriteLine("Payment ID     : " + PaymentId);
        Console.WriteLine("Bill ID        : " + BillId);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Bill Amount    : Rs. " + BillAmount);
        Console.WriteLine("Paid Amount    : Rs. " + PaidAmount);
        Console.WriteLine("Change         : Rs. " + ChangeAmount);
        Console.WriteLine("Payment Status : " + PaymentStatus);

        Console.WriteLine("========================================");
    }
}