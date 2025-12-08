// Added two options to list completed goals and to list uncompleted goals to exceed the requirements.

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