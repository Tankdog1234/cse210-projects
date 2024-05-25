using System;

public class Fraction
{
    private int _nbTop;
    private int _nbBottom;


    public Fraction()
    {
        _nbTop = 1;
        _nbBottom = 1;
    }
    public Fraction(int nbWholeNumber)
    {
        _nbTop = nbWholeNumber;
        _nbBottom = 1;
    }
    public Fraction(int nbTop, int nbBottom)
    {
        _nbTop = nbTop;
        _nbBottom = nbBottom;
    }

    public int GetTop()
    {
        return _nbTop;
    }
    public void SetTop(int nbTop)
    {
        _nbTop = nbTop;
    }
    public int GetBottom()
    {
        return _nbBottom;
    }
    public void SetBottom(int nbBottom)
    {
        _nbBottom = nbBottom;
    }

    public string GetFractionString()
    {
        return $"{_nbTop}/{_nbBottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_nbTop/(double)_nbBottom;
    }
}