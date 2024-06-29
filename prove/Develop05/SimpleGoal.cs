using System.ComponentModel;
using System.Diagnostics.Tracing;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        CreateEvent();
    }

    public SimpleGoal(string name, string desc, int points, bool isComplete)
    {
        _name = name;
        _desc = desc;
        _pointsVal = points;
        _isComplete = isComplete;
    }


    public override int RecordEvent()
    {
        /*
        This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete
        and adding to the number of times a checklist goal has been completed. It should return the point value associated
        with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just
        finished, for example).
        */
        if(_isComplete == false)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {_pointsVal} points!");
            return _pointsVal;
        }
        else
        {
            Console.WriteLine("You have already completed this goal!");
            return 0;
        }
    }

    public override bool IsComplete() //should this return a boolean?
    {
        /*
        This method should return true if the goal is completed. The way you determine if a goal is complete
        is different for each type of goal.
        */
        return _isComplete;
    }

    public override void DisplayGoal()
    {
        if(_isComplete == true)
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write("[ ] ");
        }
        Console.WriteLine($"{_name} ({_desc})");
    }

    public override string GetRawGoalData()
    {
        return $"{GetType()}|{_name}~{_desc}~{_pointsVal}~{_isComplete}";
    }
}