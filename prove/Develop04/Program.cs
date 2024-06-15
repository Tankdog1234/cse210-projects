using System;

/*
To exceed requirements, I added a few variables that keep track of the amount of times each activity has been
completed in that session.
*/

class Program
{
    static void Main(string[] args)
    {
        int reflectIterations = 0, breatheIterations = 0, listIterations = 0;
        Activity reflection = new Reflection();
        Listing listing = new Listing();
        Breathing breathing = new Breathing();
        string[] menuChoices = {reflection.GetActivityName(), breathing.GetActivityName(), listing.GetActivityName(), "Quit"};
        int userSelection = -1;

        while(userSelection != 3)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"  {i}. {menuChoices[i]}");
            }
            Console.WriteLine($"You've participated in the {reflection.GetActivityName()} {reflectIterations} time(s), {breathing.GetActivityName()} {breatheIterations} time(s), and {listing.GetActivityName()} {listIterations} time(s) this session!");
            Console.Write("Select a choice from the menu: ");
            userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch(userSelection)
            {
                case 0:
                    reflection.StartActivity();
                    reflection.RunActivity();
                    reflectIterations++;
                    break;
                case 1:
                    breathing.StartActivity();
                    breathing.RunActivity();
                    breatheIterations++;
                    break;
                case 2:
                    listing.StartActivity();
                    listing.RunActivity();
                    listIterations++;
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Please put in a valid input");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}