public abstract class Activity
{
    protected string _date;
    protected double _time;

    //constructor
    public Activity(string date, double time)
    {
        _date = date;
        _time = time;
    }

    //methods
    public abstract double GetDistance();
    public abstract double GetSpeed();

    public double GetPace()
    {
        return _time / GetDistance();
    }

    public string GetSummary()
    {
        return $"{_date} {GetType()} ({_time} mins) - Distance {Math.Round(GetDistance(), 2)} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace {Math.Round(GetPace(), 2)} mins/mile";
    }
}