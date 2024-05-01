using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [];

        Console.WriteLine("Enter a series of numbers (enter 0 to stop): ");

        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number == 0)
                    break;

                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        int sum = numbers.Sum();

        double average = numbers.Count > 0 ? numbers.Average() : 0;

        int max = numbers.Count > 0 ? numbers.Max() : 0;

        Console.WriteLine($"Sum of the numbers: {sum}");
        Console.WriteLine($"Average of the numbers: {average}");
        Console.WriteLine($"Maximum number in the list: {max}");
    }
}