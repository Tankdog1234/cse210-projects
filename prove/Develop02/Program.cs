using System;

class Program
{
    static void Main(string[] args)
    {
        Display display = new Display();
        UserPrompt promptUser = new UserPrompt();
        LoadAndSave loadAndSave = new LoadAndSave();

        Console.WriteLine("Welcome to the journal program!");

        while(true)
        {
            switch (display.DisplayMenu()) 
            {
                case 0: //quit
                    Console.WriteLine("Thanks for writing today. Hope to see you tomorrow!");
                    return;
                case 1: //write
                    promptUser.Prompt();
                    break;
                case 2: //display
                    display.DisplayEntries();
                    break;
                case 3: //load
                    loadAndSave.LoadFile();
                    break;
                case 4: //save
                    loadAndSave.SaveFile();
                    break;
                default:
                    Console.WriteLine("Please enter a valid menu choice");
                    break;
            }
        }

    }
}