public class Running : Activity
{
    private double _distance;

    //constructor
    public Running(string date, double time, double distance) : base(date, time)
    {
        _distance = distance;
    }

    //methods
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _time * 60; //convert from mi/min to mph
    }
}