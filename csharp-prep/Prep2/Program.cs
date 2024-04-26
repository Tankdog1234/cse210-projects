using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What percent score did you achieve in class?");
        string nb_scoreString = Console.ReadLine();
        float nb_score = float.Parse(nb_scoreString);

        string nb_gradeLetter;

        if (nb_score >= 90)
        {
            nb_gradeLetter = "A";
        } 
        else if (nb_score >= 80)
        {
            nb_gradeLetter = "B";
        }
        else if (nb_score >= 70)
        {
            nb_gradeLetter = "C";
        }
        else if (nb_score >= 70) 
        {
            nb_gradeLetter = "D";
        }
        else
        {
            nb_gradeLetter = "F";
        }

        Console.WriteLine($"You received a {nb_gradeLetter}.");

        if (nb_score >= 70)
        {
            Console.WriteLine("Congrats! You passed the class");
        }
        else
        {
            Console.WriteLine("Unfortunately, you failed the class. Don't give up! Keep on trying!");
        }
    }

    
}
/*
A >= 90
B >= 80
C >= 70
D >= 60
F < 60
*/