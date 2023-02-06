using System;

public class Fraction
{
    private int _topNumbers;
    private int _bottomNumbers;

    public Fraction()
    {
        _topNumbers = 1;
        _bottomNumbers = 1;
    }

    public Fraction(int top)
    {
        _topNumbers = top;
        _bottomNumbers = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumbers = top;
        _bottomNumbers = bottom;
    }

    //getters and settters
    public string GetFractionString()
    {
        string Value = ($"{_topNumbers} / {_bottomNumbers}");
        return Value;
    }
       
    public double GetDecimalValue()
    {
        double value = (double)_topNumbers / (double)_bottomNumbers;
        return value;
    }
}   