public class EternalGoal : Goal
{
    public EternalGoal()
    {
        CreateEvent();
    }

    public EternalGoal(string name, string desc, int points, int complete)
    {
        _name = name;
        _desc = desc;
        _pointsVal = points;
        _timesCompleted = complete;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_pointsVal} points!");
        _timesCompleted++;
        return _pointsVal;
    }
    
    public override bool IsComplete()
    {
        return false;
    }

    public override void DisplayGoal()
    {
        Console.Write("[ ] ");
        Console.WriteLine($"{_name} ({_desc}) Completed {_timesCompleted} times");
    }
    

    public override string GetRawGoalData()
    {
        return $"{GetType()}|{_name}~{_desc}~{_pointsVal}~{_timesCompleted}";
    }
}