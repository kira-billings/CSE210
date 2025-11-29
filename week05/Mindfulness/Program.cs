using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Mindfulness Activity Program. \nSelect the number for the activity or quit.");
        string selection = "0";
        while (selection != "4")
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your selection: ");
            selection = Console.ReadLine();
            if (selection == "1")
            {
                BreatheActivity bActivity = new BreatheActivity("\nBreathing Activity:", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing.", 44);
                bActivity.RunActivity();
            }
            if (selection == "2")
            {
                ListingActivity lActivity = new ListingActivity("\nListing Activity:", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 44);
                lActivity.RunActivity();
            }
            if (selection == "3")
            {
                ReflectActivity rActivity = new ReflectActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 44);
                rActivity.RunActivity();    
            }
        }
        Environment.Exit(0);
    }
}