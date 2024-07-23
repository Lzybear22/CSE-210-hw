using System;

public class DisplayActivities
{
    private User _user;

    public DisplayActivities(User user)
    {
        _user = user;
    }

    public void Execute()
    {
        Console.Clear();
        Console.WriteLine("Activities:");
        _user.DisplayActivities();
        Console.WriteLine("Press any key to return.");
        Console.ReadKey();
    }
}
