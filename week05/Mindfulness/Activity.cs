using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"{_name}\n{_description}");
        Console.Write($"How many seconds do you want to do this activity? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Write("Prepare to begin. Beginning in this many seconds: ");
        ShowCountDown(7);
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine($"You have completed {_duration} seconds of mindfulness. Well done!");
    }
    public void ShowSpinner(int seconds)
    {   
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> animationString = new List<string>()
        {
            "|","/","-","\\"
        };

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}