using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        var goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            if (goal is ChecklistGoal checklistGoal && checklistGoal.CurrentCount == checklistGoal.TargetCount)
            {
                score += checklistGoal.BonusPoints;
            }
            score += goal.Points;
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void ShowGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"Score: {score} points");
    }

    public void Save(string filename)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new GoalConverter() }
        };
        var data = new SaveData { Goals = goals, Score = score };
        var json = JsonSerializer.Serialize(data, options);
        File.WriteAllText(filename, json);
    }

    public void Load(string filename)
    {
        var options = new JsonSerializerOptions
        {
            Converters = { new GoalConverter() }
        };
        var json = File.ReadAllText(filename);
        var data = JsonSerializer.Deserialize<SaveData>(json, options);
        goals = data.Goals;
        score = data.Score;
    }

    private class SaveData
    {
        public List<Goal> Goals { get; set; }
        public int Score { get; set; }
    }
}
