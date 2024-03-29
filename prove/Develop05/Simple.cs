using System.IO;
public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int point) : base(name, description, point)
    {
        
    }

    public SimpleGoal(string name, string description, int point, bool isComplete) : base(name, description, point, isComplete)
    {
        
    }

    
    public override int RecordEvent(int totalPoints)
    {
        _isComplete = true;
        return totalPoints + _point;
    }
    
    public override void Status()
    {        
        //Console.WriteLine($"{_name} ({count} times, +{count * _point} points)");        
        Console.WriteLine($"[{(_isComplete ? 'X' : ' ')}] {_name} ({_description})");
    }
}

