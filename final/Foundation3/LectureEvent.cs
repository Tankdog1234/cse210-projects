public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    //constructor
    public LectureEvent(string name, string desc, Address address, string date, string time, string speaker, int capacity) : base(name, desc, address, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    //methods
    public string GetFullDetails()
    {
        return $"{GetType()} {_name}\n{_address.GetAddress()}\nOn {_date} @ {_time}\nSpeaker: {_speaker}\n{_desc} There are {_capacity} seats available for this event.";
    }
}