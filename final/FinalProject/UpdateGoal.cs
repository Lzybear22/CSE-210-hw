using System;

public class UpdateGoal
{
    private User _user;

    public UpdateGoal(User user)
    {
        _user = user;
    }

    public void Execute()
    {
        Console.Clear();
        Console.WriteLine("Update Goal");
        Console.Write("Enter goal description to update: ");
        var description = Console.ReadLine();

        var goal = _user.Goals.Find(g => g.Description.Equals(description, StringComparison.OrdinalIgnoreCase));
        if (goal != null)
        {
            double newValue;

            while (true)
            {
                Console.Write("Enter new progress value: ");
                if (double.TryParse(Console.ReadLine(), out newValue) && newValue >= 0) break;
                Console.WriteLine("Invalid progress value. Please enter a non-negative number.");
            }
            goal.Update(newValue);
        }
        else
        {
            Console.WriteLine("Goal not found. Press any key to return.");
        }
        Console.ReadKey();
    }
}
