using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();
        string user = PromptUser();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(user, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUser()
    {
        Console.WriteLine("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        int number;
        while (true)
        {
            Console.WriteLine("What is your favorite number? ");
            if (int.TryParse(Console.ReadLine(), out number))
                break;
            else
                Console.WriteLine("Invalid input. ");
        }
        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string user, int squaredNumber)
    {
        Console.WriteLine($"{user}, the square of your number is: {squaredNumber}");
    } 
    
}