using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string nb_first = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string nb_last = Console.ReadLine();

        Console.WriteLine($"Your name is {nb_last}, {nb_first} {nb_last}");
    }
}