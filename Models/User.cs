using System;

class User
{
    //Attributes--
    private int userId;
    private string username;
    private string password;
    private string fullName;
    private string role;

    // Getting and setting values
    public int UserId
    {
        get { return userId; }
        set { userId = value; }
    }
    public string UserName
    {
        get { return username; }
        set { username = value; }
    }
    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }
    public string Role
    {
        get { return role; }
        set { role = value; }
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("========== User Info ==========");
        Console.WriteLine("ID: " + UserId);
        Console.WriteLine("Name: " + FullName);
        Console.WriteLine("Username: " + UserName);
        Console.WriteLine("Role: " + Role);
    }
    public virtual void Login()
    {
        Console.WriteLine("login in process...");
    }
}

