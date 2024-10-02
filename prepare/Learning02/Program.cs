using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Sys Admin";
        job2._company = "Oracle";
        job2._startYear = 2010;
        job2._endYear = 2022;


        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._name = "Jack Sprat";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2); 

        Console.WriteLine(resume._jobs[0]._jobTitle);

       resume.DisplayResumeDetails();
    }
}