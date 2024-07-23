using System;
using System.Collections.Generic;

public class Tracker
{
    public List<Activity> Activities { get; set; } = new List<Activity>();
    public List<Goal> Goals { get; set; } = new List<Goal>();

    public void AddActivity(Activity activity)
    {
        Activities.Add(activity);
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void DisplayActivities()
    {
        foreach (var activity in Activities)
        {
            activity.Display();
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            goal.Display();
        }
    }
}
