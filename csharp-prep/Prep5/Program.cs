using System;
using System.Globalization;

/*
DisplayWelcome - Displays the message, "Welcome to the Program!"
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name and the squared number and displays them.
*/

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUsername()
    {
        string username;
        Console.WriteLine("Please input your username: ");
        username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        int favNumber;
        Console.WriteLine("Please input your most favorite number: ");
        favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int SquareNumber(int number)
    {
        number *= number;
        return number;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"Your name: {name}");
        Console.WriteLine($"Your number squared: {number}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUsername();
        int number = PromptUserNumber();
        DisplayResult(username, SquareNumber(number));
    }
}