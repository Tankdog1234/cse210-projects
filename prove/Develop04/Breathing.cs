using System;

class Breathing : Activity
{
    public Breathing() : base()
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("Breath in");
            CountdownAnimation(4);
            Console.WriteLine();
            Console.Write("Breath out");
            CountdownAnimation(6);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        DisplayEndText();
    }
}