using System;

public class Cardio : Activity
{
    public Cardio(string name, DateTime date, TimeSpan duration)
        : base(name, date, duration)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"Cardio Activity: {Name}, Date: {Date.ToShortDateString()}, Duration: {Duration}");
    }
}
