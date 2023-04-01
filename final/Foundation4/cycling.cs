using System;
class Cycling : Activity
{
    private double _speed; // in kph
    
    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    
    public override double Distance()
    {
        return _speed * GetLength() / 60;
    }
    
    public override double Speed()
    {
        return _speed;
    }
    
    public override double Pace()
    {
        return 60 / _speed;
    }
    
    public override string GetSummary()
    {
        return ($"{base.GetSummary()} Cycling ({GetLength()} min) - Distance: {Distance()} km, Speed: {_speed} kph, Pace: {Pace()} min/km");
    }
}