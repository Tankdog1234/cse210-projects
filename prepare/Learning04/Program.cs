using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Nathan Baldauf", "Calculus");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Brother Gibbons", "Derivatives", "3.6", "3-21");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Alex Peine", "Writing Unit 4", "Adverbs and Adjectives");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}