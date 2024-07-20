public class OutdoorEvent : Event
{
    private string _forecast;

    //constructor
    public OutdoorEvent(string name, string desc, Address address, string date, string time, string forecast) : base(name, desc, address, date, time)
    {
        _forecast = forecast;
    }

    //methods
    public string GetFullDetails()
    {
        return $"{GetType()} {_name}\n{_address.GetAddress()}\nOn {_date} @ {_time}\n{_desc}\n{_forecast}";
    }
}