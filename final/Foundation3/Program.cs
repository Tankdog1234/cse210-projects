using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("224 String Ave", "Linterville", "Idaho", "USA");
        LectureEvent lecture = new LectureEvent("Seeking Faith in a Secular World", "We will be covering how to grow closer to Christ despite the ever increasing challenges in the modern world.", address, "11/3/2024", "7:00pm", "Brother Gibbons", 50);
        ReceptionEvent reception = new ReceptionEvent("Celebrating a Future Together", "Please come celebrate the wedding of John and Kate with us! There will be plenty of food!", address, "4/20/2025", "5:30pm", "receptionServices@business.org");
        OutdoorEvent outdoor = new OutdoorEvent("BBQ in the Sun", "Come hungry! We'll have hot dogs, hamburgers, and water games!", address, "7/20/2024", "11:30am", "Please wear sunscreen! It's going to be a hot, 95 degrees with very little cloud cover. Winds that day will be around 15mph.");

        Console.WriteLine($"{lecture.GetDesc()}\n\n{lecture.GetStandardDetails()}\n\n{lecture.GetFullDetails()}\n\n");
        Console.WriteLine($"{reception.GetDesc()}\n\n{reception.GetStandardDetails()}\n\n{reception.GetFullDetails()}\n\n");
        Console.WriteLine($"{outdoor.GetDesc()}\n\n{outdoor.GetStandardDetails()}\n\n{outdoor.GetFullDetails()}\n");

    }
}