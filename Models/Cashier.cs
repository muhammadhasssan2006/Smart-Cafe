using System;

class Cashier : User
{
    public void GenerateBill()
    {
        Console.WriteLine("Bill Generated Successfully.");
    }
    public void TakePayment()
    {
        Console.WriteLine("Payment Received Successfully.");
    }


}