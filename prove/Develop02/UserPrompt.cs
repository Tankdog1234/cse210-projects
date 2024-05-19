using System;

public class UserPrompt
{
    private readonly string[] prompt = ["What was the highlight of your day?", "How have you seen the hand of the Lord today?", "What was something you learned today?", "What is something you did today that you're proud of?", "Who is someone you're grateful for, and why?"];

    private static string FileDate()
    {
        DateTime nbCurrentTime = DateTime.Now;
        string nbDate = nbCurrentTime.ToShortDateString();
        return nbDate;
    }

    public void Prompt()
    {
        //collect a random int from 0 to 4
        Random rnd = new Random();
        int promptNumber = rnd.Next(0,5);
        //use the random int to select a prompt. Display characters one by one
        foreach (char letter in prompt[promptNumber])
        {
            Console.Write(letter);
            Thread.Sleep(40);
        }
        Console.WriteLine();

        //collect the user input
        LoadAndSave._nbEntries.Add($"Date: {FileDate()}");
        LoadAndSave._nbEntries.Add($"Prompt: {prompt[promptNumber]}");
        LoadAndSave._nbEntries.Add(Console.ReadLine());
        LoadAndSave._nbEntries.Add(" ");
    }
}