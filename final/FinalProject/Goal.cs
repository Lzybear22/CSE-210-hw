using System;

public class Goal
{
    public string Description { get; set; }
    public double TargetValue { get; set; }
    public double CurrentValue { get; set; }

    public Goal(string description, double targetValue)
    {
        Description = description;
        TargetValue = targetValue;
        CurrentValue = 0;
    }

    public void Update(double value)
    {
        if (value < 0)
        {
            Console.WriteLine("Value cannot be negative.");
            return;
        }

        CurrentValue = Math.Min(value, TargetValue); // Ensure current value does not exceed the target
    }

    public void Display()
    {
        Console.WriteLine($"{Description}: {CurrentValue}/{TargetValue}");
    }

    public bool IsCompleted()
    {
        return CurrentValue >= TargetValue;
    }
}
