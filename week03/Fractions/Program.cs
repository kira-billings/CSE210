using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Adding this line so I can push with a better commit message.
        Fractions f1 = new Fractions();
        Fractions f2 = new Fractions(3);
        Fractions f3 = new Fractions(3, 5);

        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetFractionString());
       
    }
}