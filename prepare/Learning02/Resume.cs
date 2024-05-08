using System;

public class Resume
{
    public string _nbName = "";
    public List<Job> _nbJobs = [];  //list containing data of type Job

    public void Display()
    {
        Console.WriteLine($"Name: {_nbName}");
        Console.WriteLine($"Jobs:");

        foreach(Job job in _nbJobs)
        {
            job.Display();
        }
    }
}