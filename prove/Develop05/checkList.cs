using System.IO;

public class CheckListGoal : Goal
{

    private int _target;
    private int _count;
    public int _bonus;
    //protected int _howManyTimes;

    public CheckListGoal(string name, string description, int point, int target, int bonus) : base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public CheckListGoal(string name, string description, int point, bool isComplete, int count, int target, int bonus) : base(name, description, point, isComplete)
    {
        _target = target;
        _bonus = bonus;
        _count = count;
    }

    public override void Status()
    {
        //Console.WriteLine($"{_name} (Completed {count}/{_target} times, +{count * _point} points)");
        Console.WriteLine($"[{(_isComplete ? 'X' : ' ')}] {_name} ({_description}) --- Currently completed: {_count}/{_target} ");
    }

    public override int RecordEvent(int totalPoints)
    {
        _count++;
        Console.WriteLine($"Recorded progress on {_name} (+{_point} points)");
        totalPoints += _point;
        if (_count == _target)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations, you have completed {_name} and earned a bonus of {_bonus} points!");
            totalPoints += _point + _bonus;
        }
        return totalPoints;
    }

    public int GetCount()
    {
        return _count;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetTarget()
    {
        return _target;
    }

}