using System;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int answer = int.Parse(grade);

        string letter = "";
        string sign = "";

    if (answer >= 90)
    {
        letter = "A";
    }
    else if (answer >= 80)
    {
        letter = "B";
    }
    else if (answer >= 70)
    {
        letter = "C";
    }
    else if (answer >= 60)
    {
        letter = "D";
    }
    else
    {
        letter = "F";
    }

    int lastdigit = answer % 10;
    if (lastdigit >= 7)
    {
        sign = "+";
    }

    else if (lastdigit < 3)
    {
        sign = "-";
    }
    else
    {
        sign = "";
    }
    
    if (letter == "A" && sign == "+")
    {
        sign = "";
    }
    else if (letter == "F" && (sign == "+" || sign == "-"))
    {
        sign = "";
    }

    Console.WriteLine($"Your grade will be {letter}{sign}. ");

    if (answer >= 70)
    {
        Console.WriteLine("You passed! ");
    }
    else
    {
        Console.WriteLine("You Failed! ");
    }


    }
}