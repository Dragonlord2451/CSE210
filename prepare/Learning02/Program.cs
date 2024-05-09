using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Safe manager";
        job1._company = "Walmart";
        job1._startYear = 2002;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Team Manager";
        job2._company = "Walmart";
        job2._startYear = 2017;
        job2._endYear = 2021;

        Resume myResume = new Resume();
        myResume._name = "Jallen Steven";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}