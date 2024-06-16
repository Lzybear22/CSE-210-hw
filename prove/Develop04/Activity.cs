using System;
using System.Threading;

public abstract class Activity
{
    protected int durationInSeconds;

    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();
        PerformActivity();
        DisplayEndingMessage();
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {GetType().Name} activity...");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.WriteLine($"Duration set to {durationInSeconds} seconds.");
        PrepareToBegin();
    }

    protected abstract string GetDescription();

    protected void SetDuration()
    {
        Console.WriteLine("Please set the duration of the activity (in seconds):");
        durationInSeconds = Convert.ToInt32(Console.ReadLine());
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);
    }

    protected abstract void PerformActivity();

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed the {GetType().Name} activity.");
        Console.WriteLine($"Total time: {durationInSeconds} seconds.");
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(250);
            Console.Write("\b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }

        Console.WriteLine();
    }
}
