using System;

class Program
{
    static void Main(string[] args)
{
    int userchoice = 1;
    
    while (userchoice != 0)
    {
    Console.WriteLine("Please pick an option");
    Console.WriteLine("Write New Entry");
    Console.WriteLine("Display Journal");
    Console.WriteLine("Save Journal");
    Console.WriteLine("Load Journal");
    Console.WriteLine("0 To End Program");
    
    Console.Write("Enter your choice: ");
    string userInput = Console.ReadLine();
    
    if (!int.TryParse(userInput, out userchoice))
    {
        Console.WriteLine("Invalid input. Please enter a valid number. ");
        continue;
    }

    Console.WriteLine("You chose: " + userchoice);

    
    Console.WriteLine("Journal closed. ");
        }
    }
}