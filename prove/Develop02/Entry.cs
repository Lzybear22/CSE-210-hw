using System;
 
public class Entry
{
    public static string GeneratePrompt()
    {
        // Create a list of Prompts
        List<string> Prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };
 
        // Create a random number generator
        Random rand = new Random();
        // Generate a random index
        int randomIndex = rand.Next(Prompts.Count);
        // Get the random string from the list
        string randomString = Prompts[randomIndex];
        return randomString;
 
    }
    public static string CreateEntry()
    {
        string Prompt = GeneratePrompt();
        Console.WriteLine(Prompt);
        Console.Write("");
        string userEntry = Console.ReadLine();
        return userEntry;
    }
}