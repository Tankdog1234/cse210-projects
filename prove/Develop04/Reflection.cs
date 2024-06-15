using System;
using System.Diagnostics.Contracts;

class Reflection : Activity
{
    private List<string> _reflections;
    public Reflection() : base()
    {
        _activityName = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompt = new List<string>();
        _prompt.Add("Think of a time when you stood up for someone else.");
        _prompt.Add("Think of a time when you did something really difficult.");
        _prompt.Add("Think of a time when you helped someone in need.");
        _prompt.Add("Think of a time when you did something truly selfless.");

        _reflections = new List<string>();
        _reflections.Add("Why was this experience meaningful to you?");
        _reflections.Add("Have you ever done anything like this before?");
        _reflections.Add("How did you get started?");
        _reflections.Add("How did you feel when it was complete?");
        _reflections.Add("What made this time different than other times when you were not as successful?");
        _reflections.Add("What is your favorite thing about this experience?");
        _reflections.Add("What could you learn from this experience that applies to other situations?");
        _reflections.Add("What did you learn about yourself through this experience?");
        _reflections.Add("How can you keep this experience in mind in the future?");
    }

    public override void RunActivity()
    {
        Console.WriteLine("Consider the following prompt:\n");
        FetchPrompt(4);
        Console.Write("You may begin in");
        CountdownAnimation(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write($"> {_reflections[GetRand(9)]} ");
            PauseAnimation(5);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        DisplayEndText();
    }
}