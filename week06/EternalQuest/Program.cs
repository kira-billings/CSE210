using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the EternalQuest Project.");
        GoalManager goalManager = new GoalManager();

        goalManager.Start();


        Console.WriteLine("Go and do the things!");
        
    }
}