using System.IO;
public abstract class Goal
{
    
    protected string _description;
    protected int _point;
    protected string _name;
    protected bool _isComplete;


    public Goal(string name, string description, int point)
    {
        _name = name;
        _description = description;
        _point = point;
        _isComplete = false;
    }

    public Goal(string name, string description, int point, bool isComplete)
    {
        _name = name;
        _description = description;
        _point = point;
        _isComplete = isComplete;
    }

    public virtual void Status()
    {
        Console.WriteLine($"[{(_isComplete ? 'X' : ' ')}] {_name} ({_description})");
        // Console.WriteLine($"The goals are:\n [{(IsComplete() ? 'X' : ' ')}] {_name} ({_point} points)");
    }

    public int GetPoint()
    {
        return _point;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public abstract void RecordEvent(int totalPoints);

}