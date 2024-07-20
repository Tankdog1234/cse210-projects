using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new();
        activities.Add(new Running("03 Nov 2023", 30, 3));
        activities.Add(new Swimming("04 Nov 2023", 30, 60));
        activities.Add(new Cycling("05 Nov 2023", 90, 15));

        Console.Clear();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}