using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        reference.DisplayReferenceOptions();
        reference.PullReference(int.Parse(Console.ReadLine()));

        Scripture scripture = new Scripture(reference);
        scripture.SplitVerse();

        scripture.DisplayScripture();
        while(!scripture.IsCompletelyHidden())
        {
            scripture.HideWords();
            Console.ReadLine();
            scripture.DisplayScripture();
        }
    }
}