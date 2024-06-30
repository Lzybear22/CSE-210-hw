using System;

abstract class Goal
{
    public string Name { get; private set; }
    public int Points { get; private set; }
    public bool IsCompleted { get; protected set; }

    protected Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract string GetStatus();
}
