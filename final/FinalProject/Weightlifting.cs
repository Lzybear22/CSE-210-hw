using System;
using System.Collections.Generic;

public class Weightlifting : Activity
{
    private List<Exercise> _exercises;

    public Weightlifting(string name, DateTime date, TimeSpan duration)
        : base(name, date, duration)
    {
        _exercises = new List<Exercise>();
    }

    public void AddExercise(Exercise exercise)
    {
        _exercises.Add(exercise);
    }

    public override void Display()
    {
        Console.WriteLine($"Weightlifting Activity: {Name}, Date: {Date.ToShortDateString()}, Duration: {Duration}");
        foreach (var exercise in _exercises)
        {
            exercise.Display();
        }
    }
}
