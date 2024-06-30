using System;

class Menu
{
    private GoalManager goalManager;

    public Menu(GoalManager goalManager)
    {
        this.goalManager = goalManager;
    }

    public void Display()
    {
        while (true)
        {
            Console.WriteLine("\n1. Show Goals");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Score");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Add New Goal");
            Console.WriteLine("7. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.ShowGoals();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    goalManager.ShowScore();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    AddNewGoal();
                    break;
                case "7":
                    return;
            }
        }
    }

    private void RecordEvent()
    {
        Console.Write("Enter goal name: ");
        string goalName = Console.ReadLine();
        goalManager.RecordEvent(goalName);
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string saveFilename = Console.ReadLine();
        goalManager.Save(saveFilename);
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string loadFilename = Console.ReadLine();
        goalManager.Load(loadFilename);
    }

    private void AddNewGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose goal type: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string newName = Console.ReadLine();
        Console.Write("Enter points: ");
        int newPoints = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            goalManager.AddGoal(new SimpleGoal(newName, newPoints));
        }
        else if (goalType == "2")
        {
            goalManager.AddGoal(new EternalGoal(newName, newPoints));
        }
        else if (goalType == "3")
        {
            Console.Write("Enter target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            goalManager.AddGoal(new ChecklistGoal(newName, newPoints, targetCount, bonusPoints));
        }
    }
}
