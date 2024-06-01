using System;
using System.IO;

public class Reference
{
    private string _fileName = "scriptures.txt";
    private string _scripBook;
    private string _scripChap;
    private string _scripVerse;
    private string _scripText;

    public Reference() {}
    public Reference(string book, string chap, string verse, string text)
    {
        _scripBook = book;
        _scripChap = chap;
        _scripVerse = verse;
        _scripText = text;
    }

    public void DisplayReferenceOptions()
    {
        Console.WriteLine("Please select a scripture from these options:");
        string[] lines = File.ReadAllLines(_fileName);

        int i = 0;
        foreach(string line in lines)
        {
            string[] parts = line.Split("~");
            Console.WriteLine($"{i}. {parts[0]} {parts[1]}:{parts[2]}");
            i++;
        }

    }
    public void PullReference(int scripIndex) //2 Nep 2:25, Prov 3:5-6, Hel 5:12
    {
        string[] lines = File.ReadAllLines(_fileName);
        
        string[] parts = lines[scripIndex].Split("~");
        _scripBook = parts[0];
        _scripChap = parts[1];
        _scripVerse = parts[2];
        _scripText = parts[3];
    }
    public string GetBook()
    {
        return _scripBook;
    }
    public string GetChap()
    {
        return _scripChap;
    }
    public string GetVerse()
    {
        return _scripVerse;
    }
    public string GetText()
    {
        return _scripText;
    }
}