using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();
        Job job2 = new();

        job1._nbJobTitle = "Software Engineer";
        job1._nbCompany = "Microsoft";
        job1._nbStartYear = 2019;
        job1._nbEndYear = 2024;

        job2._nbJobTitle = "Botanist";
        job2._nbCompany = "Walmart";
        job2._nbStartYear = 2005;
        job2._nbEndYear = 2019;

        Resume resume = new();
        resume._nbName = "Nathan";

        resume._nbJobs.Add(job1);
        resume._nbJobs.Add(job2);

        resume.Display();
    }
}