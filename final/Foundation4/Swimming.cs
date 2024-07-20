public class Swimming : Activity
{
    private int _laps; //a lap is 50 meters

    //constructor
    public Swimming(string date, double time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    //methods
    public override double GetDistance()
    {
        //convert laps to m, m to km, then km to mi    50 / 1000 * 0.62 = 0.031
        return _laps * 0.031;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _time * 60; //convert from mi/min to mph
    }
}