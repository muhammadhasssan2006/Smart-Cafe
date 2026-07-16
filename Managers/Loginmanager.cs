using System;

class LoginManager
{
    private Admin admin = new Admin();
    private Cashier cashier = new Cashier();

    public LoginManager()
    {
        // Default Admin Account
        admin.UserId = 1;
        admin.FullName = "System Administrator";
        admin.UserName = "admin";
        admin.Password = "admin123";
        admin.Role = "Admin";

        // Default Cashier Account
        cashier.UserId = 2;
        cashier.FullName = "Default Cashier";
        cashier.UserName = "cashier";
        cashier.Password = "cashier123";
        cashier.Role = "Cashier";
    }

    public User Login(string username, string password)
    {
        if (username == admin.UserName && password == admin.Password)
        {
            Console.WriteLine("\nLogin Successful!");
            Console.WriteLine("Welcome Admin.\n");
            return admin;
        }

        if (username == cashier.UserName && password == cashier.Password)
        {
            Console.WriteLine("\nLogin Successful!");
            Console.WriteLine("Welcome Cashier.\n");
            return cashier;
        }

        Console.WriteLine("\nInvalid Username or Password.\n");
        return null;
    }
}