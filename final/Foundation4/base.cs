using System;
abstract class Activity
{
    private DateTime _date;
    private int _length; // in minutes
    
    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }
    public int GetLength()
    {
        return _length;
    }
    public abstract double Distance();  
    public abstract double Speed();   
    public abstract double Pace();   
    public virtual string GetSummary()
    {
        return ($"{_date.ToString("dd MMM yyyy")} ");
    }
}