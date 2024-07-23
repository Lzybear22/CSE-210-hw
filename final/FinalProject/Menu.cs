using System;

public class Menu
{
    private User _user;
    private AddActivity _addActivity;
    private AddGoal _addGoal;
    private UpdateGoal _updateGoal;
    private DisplayActivities _displayActivities;
    private DisplayGoals _displayGoals;
    private PerformWorkouts _performWorkouts;

    public Menu(User user)
    {
        _user = user;
        _addActivity = new AddActivity(_user);
        _addGoal = new AddGoal(_user);
        _updateGoal = new UpdateGoal(_user);
        _displayActivities = new DisplayActivities(_user);
        _displayGoals = new DisplayGoals(_user);
        _performWorkouts = new PerformWorkouts(_user);
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Health and Fitness Tracker");
            Console.WriteLine("1. Add Activity");
            Console.WriteLine("2. Add Goal");
            Console.WriteLine("3. Display Activities");
            Console.WriteLine("4. Display Goals");
            Console.WriteLine("5. Update Goal");
            Console.WriteLine("6. Perform Workouts");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _addActivity.Execute();
                    break;
                case "2":
                    _addGoal.Execute();
                    break;
                case "3":
                    _displayActivities.Execute();
                    break;
                case "4":
                    _displayGoals.Execute();
                    break;
                case "5":
                    _updateGoal.Execute();
                    break;
                case "6":
                    _performWorkouts.Execute();
                    break;
                case "7":
                    return; // Exit the application
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
