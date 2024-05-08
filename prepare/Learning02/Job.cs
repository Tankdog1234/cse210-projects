using System;

public class Job
{
    public string _nbCompany = "";
    public string _nbJobTitle = "";
    public int _nbStartYear;
    public int _nbEndYear;

    public void Display()
    {
        Console.WriteLine($"{_nbJobTitle} ({_nbCompany}) {_nbStartYear}-{_nbEndYear}");
    }
}