using System;

class Program
{
    static void Main(string[] args)
    {
    Job job1 = new Job();
    job1._title = "Laborer"; 
    job1._company = "Construction";
    job1._start = 2023;
    job1._end = 2024;

    Job job2 = new Job();
    job2._title = "Owner";
    job2._company = "Construction";
    job2._start = 2020;
    job2._end = 2024;

    Resume myResume = new Resume();
    myResume._name = "Hunter Nesvold";

    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);

    myResume.Display();



    }
}