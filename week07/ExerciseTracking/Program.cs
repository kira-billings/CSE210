using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        Running running = new Running("9/12/25", 78, 5);
        Cycling cycling = new Cycling("10/8/2025", 45, 10);
        Swimming swimming = new Swimming("11/12/2025", 67, 29);
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        foreach (Activity activity in activities) 
        {
            activity.GetSummary();
        }
    }
}