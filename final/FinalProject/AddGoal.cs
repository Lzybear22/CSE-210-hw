using System;

public class AddGoal
{
    private User _user;

    public AddGoal(User user)
    {
        _user = user;
    }

    public void Execute()
    {
        Console.Clear();
        Console.WriteLine("Add Goal(if cardio put time in min. Ex if 1hr 30min = 90min.)");
        Console.Write("Enter goal description: ");
        var description = Console.ReadLine();

        double targetValue;
        
        while (true)
        {
            Console.Write("Enter target value: ");
            if (double.TryParse(Console.ReadLine(), out targetValue) && targetValue >= 0) break;
            Console.WriteLine("Invalid target value. Please enter a non-negative number.");
        }

        _user.AddGoal(new Goal(description, targetValue));
    }
}
