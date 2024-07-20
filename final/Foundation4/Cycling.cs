public class Cycling : Activity
{
    private double _speed;

    //constructor
    public Cycling(string date, double time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    //methods
    public override double GetDistance()
    {
        return GetSpeed() / 60 * _time; //convert speed to mi/min
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}