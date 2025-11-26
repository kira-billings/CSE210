using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Randy Billings", "Geometry", "5.1", "1-20");
        string studentSummary = mathAssignment.GetSummary();
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Kira Billings", "Creative Writing", "Science Fiction"); 
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}