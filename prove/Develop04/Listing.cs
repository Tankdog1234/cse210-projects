using System;
using System.Runtime.CompilerServices;

class Listing : Activity
{

    public Listing() : base()
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompt = new List<string>();
        _prompt.Add("Who are people that you appreciate?");
        _prompt.Add("What are personal strengths of yours?");
        _prompt.Add("Who are people that you have helped this week?");
        _prompt.Add("When have you felt the Holy Ghost this month?");
        _prompt.Add("Who are some of your personal heroes?");
    }

    public override void RunActivity()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        FetchPrompt(4);
        Console.Write("You may begin in");
        CountdownAnimation(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        DateTime currentTime = DateTime.Now;
        List<string> inputs = new List<string>();
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            inputs.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"Good job! You listed {inputs.Count} items!");
        DisplayEndText();
    }
}