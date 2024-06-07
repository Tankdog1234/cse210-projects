using System;
using System.ComponentModel.DataAnnotations;

public class Word
{
    private string _word;
    private string _blankWord;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        foreach(char letter in word)
        {
            _blankWord += "_";
        }
    }

    public void Hide() 
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetText()
    {
        if(_isHidden == true) 
        {
            return _blankWord;
        } 
        else
        {
            return _word;
        }
    }
}