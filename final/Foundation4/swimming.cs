using System;
class Swimming : Activity
{
    private int _laps;
    
    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }
    
    public override double Distance()
    {
        return _laps * 50 / 1000.0;
    }
    
    public override double Speed()
    {
        return Distance() / GetLength() * 60;
    }
    
    public override double Pace()
    {
        return GetLength() / Distance();
    }
    
    public override string GetSummary()
    {
        return ($"{base.GetSummary()} Swimming ({GetLength()} min) - Distance: {Distance()} km, Speed: {Speed()} kph, Pace: {Pace()} min/km");
    }
}