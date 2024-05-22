using System;

class Program
{
    static void Main(string[] args)
    {
    Fraction frac1 = new Fraction();
    Console.WriteLine(frac1.GetDecimalValue());
    Console.WriteLine(frac1.GetFractionString());

    Fraction frac2 = new Fraction(5);
    Console.WriteLine(frac2.GetDecimalValue());
    Console.WriteLine(frac2.GetFractionString());

    Fraction frac3 = new Fraction(3,4);
    Console.WriteLine(frac3.GetDecimalValue());
    Console.WriteLine(frac3.GetFractionString());

    Fraction frac4 = new Fraction(1, 3);
    Console.WriteLine(frac4.GetDecimalValue());
    Console.WriteLine(frac4.GetFractionString());

    }
}