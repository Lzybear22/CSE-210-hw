using System;
using System.Threading;

public class Breathing : Activity
{
    protected override string GetDescription()
    {
        return "This activity will help you relax by guiding you through breathing exercises.";
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Clear your mind and focus on your breathing.");

        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(3);
            if (DateTime.Now >= endTime) break;

            Console.WriteLine("Breathe out...");
            PauseWithAnimation(3);
        }
    }
}
