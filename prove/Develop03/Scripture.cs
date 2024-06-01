using System;

public class Scripture 
{
    private string _scripText;
    private string[] _wordsArray;
    private List<Word> _wordsList;
    private Reference reference;

    public Scripture(Reference inputReference)
    {
        reference = inputReference;
        _scripText = reference.GetText();
        _wordsArray = _scripText.Split(" ");
        _wordsList = new List<Word>();
    }

    public void SplitVerse()
    {
        foreach(string word in _wordsArray)
        {
            _wordsList.Add(new Word(word));
        }
    }
    public void HideWords()
    {
        Random random = new Random();
        int randomInt;
        for (int i = 0; i < 5; i++)
        {
            randomInt = random.Next(_wordsArray.Length);
            _wordsList[randomInt].Hide();
        }
    }
    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine("Press enter to hide more words...");
        Console.WriteLine($"{reference.GetBook()} {reference.GetChap()}:{reference.GetVerse()}");
        foreach(Word word in _wordsList)
        {
            Console.Write($"{word.GetText()} ");
        }
    }
    public bool IsCompletelyHidden()
    {
        bool wordIsHidden = true;
        foreach(Word word in _wordsList)
        {
            if(word.IsHidden() == false)
            {
                wordIsHidden = false;
            }
        }
        return wordIsHidden;
    }
}