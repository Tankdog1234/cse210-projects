using System;

class Activity
{
    protected int _time;
    protected List<string> _prompt;
    protected string _activityName;
    protected string _description;

    public Activity()
    {
        _prompt = new List<string>();
    }

    protected void EnterTime()
    {
        Console.Write("How long (in seconds) would you like your session to be? ");
        _time = int.Parse(Console.ReadLine());
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    protected int GetRand(int maxIndex)
    {
        Random rand = new Random();
        int randInt = rand.Next(maxIndex);
        return randInt;
    }
    protected void FetchPrompt(int maxIndex)
    {
        Console.WriteLine($"---{_prompt[GetRand(maxIndex)]}---\n");
    }
    protected void DisplayStartText()
    {
        Console.WriteLine("Get ready...");
        PauseAnimation(4);
    }
    protected void DisplayEndText()
    {
        Console.WriteLine("Well done!\n");
        PauseAnimation(4);
        Console.WriteLine($"You have successfully completed another {_time} seconds of the {_activityName}");
        PauseAnimation(4);
    }
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}\n");
        Console.WriteLine($"{_description}\n");
        EnterTime();
        Console.Clear();
        DisplayStartText();
        Console.Clear();
    }
    public virtual void RunActivity() {}
    protected void CountdownAnimation(int pauseTime)
    {
        Console.Write("...");
        for(int i = pauseTime; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
    protected void PauseAnimation(int pauseTime)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(pauseTime);

        DateTime currentTime = DateTime.Now;
        const int SPINDELAY = 150;
        while (currentTime < futureTime)
        {
            Console.Write("/");
            Thread.Sleep(SPINDELAY);
            Console.Write("\b");
            
            Console.Write("—");
            Thread.Sleep(SPINDELAY);
            Console.Write("\b");
            
            Console.Write("\\");
            Thread.Sleep(SPINDELAY);
            Console.Write("\b");

            Console.Write("|");
            Thread.Sleep(SPINDELAY);
            Console.Write("\b");

            currentTime = DateTime.Now;
        }
        Console.Write("\b \b");
    }
}