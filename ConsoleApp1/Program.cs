#region Task 1

class Account()
{
    string Username;
    string Password;

    public void Login()
    {
        if (Username == "Admin" || Password == "AdminEA18yr@")
        {
            Console.WriteLine("Ugurlu giris");
            return;
        }
        Console.WriteLine("Username ve ya parol dogru deyil");
    }
}

#endregion

#region Task 2

class User()
{
    string FirstName;
    string LastName;
    string Email;
    string Password;
    DateTime Birthday;
    bool Gender;

    void Register()
    {
        if (!string.IsNullOrEmpty(Password) || !string.IsNullOrEmpty(Email)) 
        {
            Console.WriteLine("Reqistrasiya ugurludur!");
            return;
        }
        Console.WriteLine("Ugursuz");
    }
}

#endregion