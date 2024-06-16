using System;
using System.Threading;

public class Reflection : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    protected override string GetDescription()
    {
        return "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            PauseWithAnimation(3);
            if (DateTime.Now >= endTime) break;

            foreach (var question in questions)
            {
                Console.WriteLine(question);
                PauseWithAnimation(3);
                if (DateTime.Now >= endTime) break;
            }
        }
    }
}
