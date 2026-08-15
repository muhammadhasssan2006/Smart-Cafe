using System;

class CashierMenu
{
    private OrderManager orderManager;
    private BillingManager billingManager = new BillingManager();
    private PaymentManager paymentManager = new PaymentManager();
    private Bill currentBill;


    public CashierMenu(OrderManager orderManager)
    {
        this.orderManager = orderManager;
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("        CASHIER PANEL");
            Console.WriteLine("================================");
            Console.WriteLine("1. Create Order");
            Console.WriteLine("2. Add Item To Order");
            Console.WriteLine("3. View Orders");
            Console.WriteLine("4. Search Order");
            Console.WriteLine("5. Cancel Order");
            Console.WriteLine("6. Generate Bill");
            Console.WriteLine("7. Take Payment");
            Console.WriteLine("8. View Payments");
            Console.WriteLine("9. Logout");
            Console.Write("\nSelect Option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    orderManager.CreateOrder();
                    break;

                case 2:
                    orderManager.AddItemToOrder();
                    break;

                case 3:
                    orderManager.ViewOrders();
                    break;

                case 4:
                    orderManager.SearchOrder();
                    break;

                case 5:
                    orderManager.CancelOrder();
                    break;

                case 6:
                    Console.Write("Enter Order ID: ");
                    int orderId = Convert.ToInt32(Console.ReadLine());

                    Order order = orderManager.GetOrderById(orderId);

                    if (order == null)
                    {
                        Console.WriteLine("\nOrder Not Found.");
                        Console.ReadKey();
                        break;
                    }

                    currentBill = billingManager.CreateBill(order);
                    break;
                case 7:
                    if (currentBill == null)
                    {
                        Console.WriteLine("\nPlease Generate Bill First.");
                        Console.ReadKey();
                        break;
                    }

                    paymentManager.TakePayment(currentBill);
                    break;

                case 8:
                    paymentManager.ViewPayments();
                    break;

                case 9:
                    Console.WriteLine("\nLogging Out...");
                    Console.ReadKey();
                    return;

                default:
                    Console.WriteLine("\nInvalid Choice!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}

