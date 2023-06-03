using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2017;
        job1._endYear = 2020;
;
        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Apple";
        job2._startYear = 2018;
        job2._endYear = 2021;
        
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume my_resume = new Resume();
        my_resume._name = "Scott Kishpaugh";

        my_resume._jobs.Add(job1);
        my_resume._jobs.Add(job2);

        my_resume.DisplayResume();
        
    }
    
}