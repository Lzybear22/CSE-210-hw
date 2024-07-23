using System.Collections.Generic;

public class User
{
    public string Name { get; set; }
    public Tracker Tracker { get; set; }

    public User(string name)
    {
        Name = name;
        Tracker = new Tracker();
    }

    public void AddActivity(Activity activity)
    {
        Tracker.AddActivity(activity);
    }

    public void AddGoal(Goal goal)
    {
        Tracker.AddGoal(goal);
    }

    public void DisplayActivities()
    {
        Tracker.DisplayActivities();
    }

    public void DisplayGoals()
    {
        Tracker.DisplayGoals();
    }

    public List<Goal> Goals => Tracker.Goals;
    public List<Activity> Activities => Tracker.Activities;
}
