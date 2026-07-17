using System;
using System.Collections.Generic;

class OrderManager
{
    private List<Order> orders = new List<Order>();
    private MenuManager menuManager;

    public OrderManager(MenuManager menuManager)
    {
        this.menuManager = menuManager;
    }

    // Create New Order
    public void CreateOrder()
    {
        Console.Clear();

        Console.WriteLine("========== CREATE ORDER ==========");

        Console.Write("Enter Order ID: ");
        int orderId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Customer Name: ");
        string customerName = Console.ReadLine();

        Console.Write("Order Type (Dine In / Take Away): ");
        string orderType = Console.ReadLine();

        Order order = new Order(orderId, customerName, orderType);

        orders.Add(order);

        Console.WriteLine("\nOrder Created Successfully.");
        Console.ReadKey();
    }

    // Add Item To Order
    public void AddItemToOrder()
    {
        Console.Clear();

        Console.Write("Enter Order ID: ");
        int orderId = Convert.ToInt32(Console.ReadLine());

        Order selectedOrder = null;

        foreach (Order order in orders)
        {
            if (order.OrderId == orderId)
            {
                selectedOrder = order;
                break;
            }
        }

        if (selectedOrder == null)
        {
            Console.WriteLine("\nOrder Not Found.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("\n========== MENU ==========");

        foreach (MenuItem item in menuManager.MenuItems)
        {
            item.DisplayMenuItem();
        }

        Console.Write("\nEnter Menu Item ID: ");
        int itemId = Convert.ToInt32(Console.ReadLine());

        MenuItem selectedItem = null;

        foreach (MenuItem item in menuManager.MenuItems)
        {
            if (item.ItemId == itemId)
            {
                selectedItem = item;
                break;
            }
        }

        if (selectedItem == null)
        {
            Console.WriteLine("\nMenu Item Not Found.");
            Console.ReadKey();
            return;
        }

        Console.Write("Enter Quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        OrderItem orderItem = new OrderItem(selectedItem, quantity);

        selectedOrder.AddItem(orderItem);

        Console.WriteLine("\nItem Added To Order Successfully.");
        Console.ReadKey();
    }


    // View All Orders
    public void ViewOrders()
    {
        Console.Clear();

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

    // Search Order
    public void SearchOrder()
    {
        Console.Clear();

        Console.Write("Enter Order ID To Search: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach (Order order in orders)
        {
            if (order.OrderId == searchId)
            {
                order.DisplayOrder();
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nOrder Not Found.");
        }

        Console.ReadKey();
    }


    // Cancel Order
    public void CancelOrder()
    {
        Console.Clear();

        Console.Write("Enter Order ID To Cancel: ");
        int cancelId = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach (Order order in orders)
        {
            if (order.OrderId == cancelId)
            {
                order.Status = "Cancelled";

                Console.WriteLine("\nOrder Cancelled Successfully.");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nOrder Not Found.");
        }

        Console.ReadKey();
    }
}