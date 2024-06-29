using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _name;
    protected string _desc;
    protected int _pointsVal;
    protected bool _isComplete;
    protected int _timesCompleted;

    public Goal() {}

    public virtual void CreateEvent()
    {
        Console.Write("What is the name of the goal you would like to create?: ");
        _name = Console.ReadLine();
        Console.Write("Please write a short description of the goal: ");
        _desc = Console.ReadLine();
        Console.Write("What value of points are associated with this goal? ");
        _pointsVal = int.Parse(Console.ReadLine());
        _isComplete = false;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract void DisplayGoal();
    public abstract string GetRawGoalData();
}