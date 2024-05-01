using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomnumber = new Random();
        int magicnumber = randomnumber.Next(1, 100);

        int guess = -1;

        while (guess != magicnumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicnumber > guess)
            {
                Console.WriteLine("Higher.");
            }
            else if (magicnumber < guess)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                Console.WriteLine("You guessed right! ");
            }
        }
    }
}