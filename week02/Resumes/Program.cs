using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._endYear = 2023;
        job1._startYear = 2000;
        
        Job job2 = new Job();
        job2._company = "Apple";
        job2._endYear = 1999;
        job2._jobTitle = "Junior developer";
        job2._startYear = 1994;

        Resume myResume = new Resume();
        myResume._memberName = "Kira Billings";
        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        myResume.DisplayMyResume();
        
    }
}