using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Reference reference = new Reference("John", 3, "16");
        Scripture scripture = new Scripture(scriptureText, reference);

        while (!scripture.IsFullyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetFormattedScripture());
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit...");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Exiting the program...");
                break;
            }

            scripture.HideRandomWord();
        }

        if (scripture.IsFullyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetFormattedScripture());
            Console.WriteLine("\nAll words are hidden. Program will now end.");
        }
    }
}
