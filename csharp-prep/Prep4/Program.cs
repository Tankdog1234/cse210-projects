using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, and when you're through, enter 0");

        List<float> nb_numbers = new List<float>();
        float nb_userInput = -1;
        while (nb_userInput != 0)
        {
            nb_userInput = float.Parse(Console.ReadLine());
            nb_numbers.Add(nb_userInput);
        }

        float nb_sum = 0;
        float nb_average = 0;
        float nb_maximum = 0;
        int iterations = 0;
        foreach(float number in nb_numbers)
        {
            Console.WriteLine(number);
            nb_sum += number;
            iterations++;

            if(number > nb_maximum)
            {
                nb_maximum = number;
            }
        }
        nb_average = nb_sum / iterations;

        Console.WriteLine($"Sum: {nb_sum}");
        Console.WriteLine($"Average: {nb_average}");
        Console.WriteLine($"Maximum: {nb_maximum}");
    }
}