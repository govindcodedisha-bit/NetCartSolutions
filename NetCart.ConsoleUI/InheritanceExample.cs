using System;
using System.Collections.Generic;
using System.Text;

namespace NetCart.ConsoleUI;

public class User
{
    public virtual void GetRole()
    {
        Console.WriteLine("User");
    }

    public void Show()
    {
        Console.WriteLine("User Show");
    }

    public virtual void UserMethod()
    {
        Console.WriteLine("User Method");
    }
}

public class Admin : User
{
    //public override void GetRole()
    //{
    //    Console.WriteLine("Admin");
    //}
    public new void Show()
    {
        Console.WriteLine("Admin Show");

        base.Show();
    }
    //public override void Show()
    //{
    //    Console.WriteLine("Admin Show");
    //}

    public void AdminDisplay()
    {
        Console.WriteLine("Super Admin Display");
    }
}

public class SuperAdmin : Admin
{
    public void SuperAdminDisplay()
    {
        Console.WriteLine("Super Admin Display");
    }
}

