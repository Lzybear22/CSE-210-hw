using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();

        var user = new User(name);

        var menu = new Menu(user);
        menu.ShowMenu();
    }
}
