using System;

public abstract class Activity
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Duration { get; set; }

    protected Activity(string name, DateTime date, TimeSpan duration)
    {
        Name = name;
        Date = date;
        Duration = duration;
    }

    public abstract void Display();
}
