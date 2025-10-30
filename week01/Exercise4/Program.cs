using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string entry;
        int entryNumber;
        Console.WriteLine("Enter a list of numbers, type 0 to quit.");
        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Enter number: ");
            entry = Console.ReadLine();
            entryNumber = int.Parse(entry);
            if (entryNumber != 0)
            {
            numbers.Add(entryNumber);
            }
        } while (entryNumber != 0);
        int sumNumbers = numbers.Sum();
        double averageNumbers = numbers.Average();
        int largestNumber = 0;
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The sum is : {sumNumbers}");
        Console.WriteLine($"The average is: {averageNumbers}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}
        