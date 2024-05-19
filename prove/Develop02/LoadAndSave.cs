using System;
using System.IO;

public class LoadAndSave
{
    public static List<string> _nbEntries = new();
    public static string _nbFileName;

    public void SaveFile()
    {
        Console.WriteLine("What file would you like to save to? 'example.txt'");
        _nbFileName = Console.ReadLine();
        StreamWriter nbOutputFile = new StreamWriter(_nbFileName);
            foreach (string entry in _nbEntries)
            {
                nbOutputFile.WriteLine(entry);
            }
        nbOutputFile.Close();
    }
    
    public void LoadFile()
    {
        Console.WriteLine("What file would you like to load today? 'example.txt'");
        _nbFileName = Console.ReadLine();
        string[] linesArray = File.ReadAllLines(_nbFileName);
        _nbEntries = linesArray.ToList();
    }
}