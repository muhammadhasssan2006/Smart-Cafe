using System;
class Admin : User
{
    public void AddMenuItem()
    {
        Console.WriteLine("Admin added a new item.");
    }
    public void RemoveMenuItem()
    {
        Console.WriteLine("Admin removed a menu item.");
    }

}