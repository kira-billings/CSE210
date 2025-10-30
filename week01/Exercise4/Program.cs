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
            numbers.Add(entryNumber);
        } while (entryNumber != 0);
        int sumNumbers = numbers.Sum();
            // foreach (int number in numbers)
           
        Console.WriteLine($"The sum is : {sumNumbers}");
            // Console.WriteLine($"The average is: {average}");
            // Console.WriteLine($"The largest number is: {largest}");
        
        // for (int i = 0; i < numbers.Count; i++)
        // {
        //     Console.WriteLine(numbers[i]);
        // }    
        // Console.WriteLine(numbers.Count);
    }
}
        