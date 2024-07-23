using System;

public class AddActivity
{
    private User _user;

    public AddActivity(User user)
    {
        _user = user;
    }

    public void Execute()
    {
        Console.Clear();
        Console.WriteLine("Add Activity");
        Console.WriteLine("1. Cardio");
        Console.WriteLine("2. Weightlifting");
        Console.Write("Choose activity type: ");
        var type = Console.ReadLine();

        Console.Write("Enter activity name: ");
        var name = Console.ReadLine();

        DateTime date;
        TimeSpan duration;

        while (true)
        {
            Console.Write("Enter activity date (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out date)) break;
            Console.WriteLine("Invalid date format. Please try again.");
        }

        while (true)
        {
            Console.Write("Enter duration (hours:minutes): ");
            if (TimeSpan.TryParse(Console.ReadLine(), out duration)) break;
            Console.WriteLine("Invalid duration format. Please try again.");
        }

        if (type == "1")
        {
            _user.AddActivity(new Cardio(name, date, duration));
        }
        else if (type == "2")
        {
            var weightlifting = new Weightlifting(name, date, duration);
            Console.WriteLine("Add Exercises:");
            while (true)
            {
                Console.Write("Enter exercise name (or 'done' to finish): ");
                var exerciseName = Console.ReadLine();
                if (exerciseName.ToLower() == "done") break;

                int sets;
                int reps;

                while (true)
                {
                    Console.Write("Enter sets: ");
                    if (int.TryParse(Console.ReadLine(), out sets) && sets > 0) break;
                    Console.WriteLine("Invalid number of sets. Please enter a positive integer.");
                }

                while (true)
                {
                    Console.Write("Enter reps: ");
                    if (int.TryParse(Console.ReadLine(), out reps) && reps > 0) break;
                    Console.WriteLine("Invalid number of reps. Please enter a positive integer.");
                }

                weightlifting.AddExercise(new Exercise(exerciseName, sets, reps));
            }
            _user.AddActivity(weightlifting);
        }
        else
        {
            Console.WriteLine("Invalid type. Press any key to return.");
            Console.ReadKey();
        }
    }
}
