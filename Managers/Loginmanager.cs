class LoginHandler
{
    Admin admin = new Admin();
    Cashier cashie = new Cashier();
    public LoginHandler()
    {
        // admin-----
        admin.UserId = 1;
        admin.FullName = "Muhammad Hassan";
        admin.UserName = "admin";
        admin.Password = "admin123";
        admin.Role = "Admin";
        // Cashier------
        cashie.UserId = 2;
        cashie.FullName = "cashier";
        cashie.UserName = "cashier";
        cashie.Password = "cashier123";
        cashie.Role = "Cashier";
    }




}