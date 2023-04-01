using System;
class Activity
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
    public virtual double Distance()
    {
        return 0;
    }    
    public virtual double Speed()
    {
        return 0;
    }    
    public virtual double Pace()
    {
        return 0;
    }    
    public virtual string GetSummary()
    {
        return ($"{_date.ToString("dd MMM yyyy")} ");
    }
}