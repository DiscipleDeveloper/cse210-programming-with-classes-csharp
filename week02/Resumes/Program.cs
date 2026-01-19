using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "10x Software Engineer";
        job1._company = "Google";
        job1._startYear = 2030;
        job1._endYear = 2050;
        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Entrepreneur";
        job2._company = "Bright English Tutorial Center";
        job2._startYear = 2026;
        job2._endYear = 2065;
        // job2.DisplayJobDetails();

        Console.WriteLine();

        Resume paulResume = new Resume();
        paulResume._name = "Napoleon B. Tumale";
        paulResume._jobs.Add(job1);
        paulResume._jobs.Add(job2);

        // Console.WriteLine(paulResume._jobs[0]._jobTitle);

        paulResume.DisplayResume();
    }
}