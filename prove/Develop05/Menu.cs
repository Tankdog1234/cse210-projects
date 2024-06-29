using System.Runtime.CompilerServices;

public class Menu : LoadAndSave
{
    private List<string> _menuOptions;
    private List<string> _goalOptions;


    public Menu() : base()
    {
        _menuOptions = ["Create new goal", "List goals", "Save Goals", "Load Goals", "Record Event", "Quit"];
        _goalOptions = ["Simple goal", "Eternal goal", "Checklist goal"];
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

    public int GetUserInput()
    {
        Console.Write("Please select one: ");
        return int.Parse(Console.ReadLine());
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine($" {i}. {_goalOptions[i]}");
        }
        switch(GetUserInput())
        {
            case 0:
                _goals.Add(new SimpleGoal());
                break;
            case 1:
                _goals.Add(new EternalGoal());
                break;
            case 2:
                _goals.Add(new ChecklistGoal());
                break;
            default:
                Console.WriteLine("Please select a valid menu option.");
                Thread.Sleep(1500);
                break;
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        int i = 0;
        foreach(Goal goal in _goals)
        {
            Console.Write($"{i}. ");
            goal.DisplayGoal();
            i++;
        }
    }

    public void RecordEvents()
    {
        Console.WriteLine("Which goal did you accomplish?");
        ListGoals();
        Goal goal = _goals[GetUserInput()];
        _points += goal.RecordEvent();
    }

    public int Display()
    {
        Console.Clear();
        Console.WriteLine($"Total Points: {_points}");
        Console.WriteLine("Menu Options:");
        for(int i = 0; i < 6; i++)
        {
            Console.WriteLine($" {i}. {_menuOptions[i]}");
        }

        int userInput = GetUserInput();
        switch(userInput)
        {
            case 0: //create new goal
                CreateGoal();
                PauseAnimation(5);
                break;
            case 1: //list goals
                ListGoals();
                PauseAnimation(5);
                break;
            case 2: //save goals
                SaveGoals();
                PauseAnimation(5);
                break;
            case 3: //load goals
                LoadGoals();
                PauseAnimation(5);
                break;
            case 4: //record event
                RecordEvents();
                PauseAnimation(5);
                break;
            case 5: //quit
                return userInput;
            default:
                Console.WriteLine("Please select a valid menu option.");
                PauseAnimation(2);
                break;
        }
        return userInput;
    }
    
}