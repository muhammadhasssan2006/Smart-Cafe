using System;

class CashierMenu
{
    private OrderManager orderManager;

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
            Console.WriteLine("6. Logout");

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

