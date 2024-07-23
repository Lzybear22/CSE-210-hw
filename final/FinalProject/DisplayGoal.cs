using System;

public class DisplayGoals
{
    private User _user;

    public DisplayGoals(User user)
    {
        _user = user;
    }

    public void Execute()
    {
        Console.Clear();
        Console.WriteLine("Goals:");
        _user.DisplayGoals();
        Console.WriteLine("Press any key to return.");
        Console.ReadKey();
    }
}
