using System;
class Running : Activity
{
    private double _distance; // in miles
    
    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    
    public override double Distance()
    {
        return _distance;
    }
    
    public override double Speed()
    {
        return _distance / GetLength() * 60;
    }
    
    public override double Pace()
    {
        return GetLength() / _distance;
    }
    
    public override string GetSummary()
    {
        return ($"{base.GetSummary()} Running ({GetLength()} min) - Distance: {_distance} miles, Speed: {Speed()} mph, Pace: {Pace()} min/mile");
    }
}