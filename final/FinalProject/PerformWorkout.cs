using System;

public class PerformWorkouts
{
    private User _user;

    public PerformWorkouts(User user)
    {
        _user = user;
    }

    public void Execute()
    {
        Console.Clear();
        Console.WriteLine("Perform Workouts");
        foreach (var activity in _user.Activities)
        {
            if (activity is Weightlifting weightlifting)
            {
                weightlifting.Display();
            }
        }
        Console.WriteLine("Press any key to return.");
        Console.ReadKey();
    }
}
