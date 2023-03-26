using System.IO;
public class EternalGoal : Goal
 {
    
    private int _count;

    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {
        _count = 0;
    }

    public EternalGoal(string name, string description, int point, bool isComplete, int count) : base(name, description, point, isComplete)
    {
        _count = count;
    }

    public override void Status()
    {
        //Console.WriteLine($"{_name} ({count} times, +{count * _point} points)");
        Console.WriteLine($"[{(_isComplete ? 'X' : ' ')}] {_name} ({_description})");
    }

    public override void RecordEvent(int totalPoints)
    {
        _count++;
        Console.WriteLine($"Recorded progress on {_name} (+{_point} points)");
    }
   
   public int GetCount()
   {
        return _count;
   }
}