using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the score percentage: ");
        string gradeInput = Console.ReadLine();
        int gradeScore = int.Parse(gradeInput);
        string letter = "";
        if (gradeScore >= 90)
        {
            letter = "A";
        }
        else if (gradeScore >= 80)
        {
            letter = "B";
        }
        else if (gradeScore >= 70)
        {
            letter = "C";
        }
        else if (gradeScore >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");
        if (gradeScore >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine("You didn't pass but I encourage you to keep trying. You can do it!");
        }
    }
}