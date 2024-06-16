using System;
using System.Threading;

public class Listing : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override string GetDescription()
    {
        return "This activity will help you reflect on the good things in your life by listing them.";
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        PauseWithAnimation(3);

        Console.WriteLine("Start listing...");
        int itemCounter = 0;
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCounter++;
            }
        }

        Console.WriteLine($"Number of items listed: {itemCounter}");
    }
}
