using System;

public class Display
{
    private string[] menuOptions = ["0. Quit", "1. Write", "2. Display", "3. Load", "4. Save"];

    public int DisplayMenu()
    {
        //display each of the menu options on their own line
        foreach(string item in menuOptions)
        {
            foreach (char letter in item)
            {
                Console.Write(letter);
                Thread.Sleep(25);
            }
            Console.WriteLine();
        }
        //prompt the user and return their response as an integer
        Console.Write("What would you like to do? ");
        return int.Parse(Console.ReadLine());
    }

    public void DisplayEntries()
    {
        Console.WriteLine("=========================");
        //display the list of journal entries
        foreach (string entry in LoadAndSave._nbEntries)
        {
            foreach (char letter in entry)
            {
                Console.Write(letter);
                Thread.Sleep(25);
            }
            Console.WriteLine();
        }
    }
}