using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int nb_magicNumber = randomGenerator.Next(1, 100);

        int nb_userInput = 0;
        
        Console.WriteLine("I've thought of a number!");

        while (nb_userInput != nb_magicNumber)
        {
            Console.WriteLine("Your guess? ");
            nb_userInput = int.Parse(Console.ReadLine());
            if (nb_userInput < nb_magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (nb_userInput > nb_magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Congrats! You guessed it!!!");
                return;
            }
        }
    }
}