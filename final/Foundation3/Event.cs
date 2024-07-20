using System.Net.Sockets;

public class Event
{
    protected string _name;
    protected string _desc;
    protected Address _address;
    protected string _date;
    protected string _time;

    //constructor
    public Event(string name, string desc, Address address, string date, string time)
    {
        _name = name;
        _desc = desc;
        _address = address;
        _date = date;
        _time = time;
    }

    //methods
    //Lists the title, description, date, time, and address.
    public string GetStandardDetails()
    {
        return $"{_name}\n{_desc}\n{_address.GetAddress()}\nOn {_date} @ {_time}";
    }

    public string GetDesc()
    {
        return $"{GetType()} {_name}\nOn {_date}";
    }
}