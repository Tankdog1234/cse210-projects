public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _timesRequired;


    public ChecklistGoal()
    {
        CreateEvent();
        _timesCompleted = 0;
        Console.Write("How many times should this goal be completed? ");
        _timesRequired = int.Parse(Console.ReadLine());
        Console.Write("What value of bonus points come with completing this goal? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public ChecklistGoal(string name, string desc, int points, int bonus, int req, int complete)
    {
        _name = name;
        _desc = desc;
        _pointsVal = points;
        _bonusPoints = bonus;
        _timesRequired = req;
        _timesCompleted = complete;
    }
 

    public override int RecordEvent()
    {
        /*
        This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete
        and adding to the number of times a checklist goal has been completed. It should return the point value associated
        with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just
        finished, for example).
        */
        if(IsComplete() == false)
        {
            _timesCompleted++;
            if(_timesCompleted == _timesRequired)
            {
                Console.WriteLine($"Congratulations! You earned {_pointsVal}, with a bonus {_bonusPoints} points!");
                return _pointsVal + _bonusPoints;
            }
            else
            {
                Console.WriteLine($"Congratulations! You have earned {_pointsVal} points!");
                return _pointsVal;
            }
        }
        else
        {
            Console.WriteLine("You have already completed this goal!");
            return 0;
        }
    }
    
    public override bool IsComplete()
    {
        if(_timesCompleted == _timesRequired)
        {
            _isComplete = true;
            return true;
        }
        else
        {
            return false;
        } 
    }

    public override void DisplayGoal()
    {
        if(IsComplete() == true)
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write("[ ] ");
        }
        Console.WriteLine($"{_name} ({_desc}) - Completed {_timesCompleted}/{_timesRequired} times");
    }

    public override string GetRawGoalData()
    {
        return $"{GetType()}|{_name}~{_desc}~{_pointsVal}~{_bonusPoints}~{_timesRequired}~{_timesCompleted}";
    }
}