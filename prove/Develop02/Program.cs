using System;
 
class Program
{
    static void Main(string[] args)
    {
        int userChoice = 1;
        while (userChoice != 0)
        {  
            Console.WriteLine("Journal Options");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("0. Exit Program.");
            Console.Write("Choose a number: ");
            userChoice = int.Parse(Console.ReadLine());
 
            if (userChoice == 1)
            {
                string userEntry = Entry.CreateEntry();
                Console.WriteLine(userEntry);
            }
        }
 
 
    }
}