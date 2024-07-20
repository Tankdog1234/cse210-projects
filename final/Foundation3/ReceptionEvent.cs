public class ReceptionEvent : Event
{
    private string _rsvpEmail;

    //constructor
    public ReceptionEvent(string name, string desc, Address address, string date, string time, string email) : base(name, desc, address, date, time)
    {
        _rsvpEmail = email;
    }

    //methods
    public string GetFullDetails()
    {
        return $"{GetType()} {_name}\n{_address.GetAddress()}\nOn {_date} @ {_time}\n{_desc}\nPlease RSVP to: {_rsvpEmail}";
    }
}