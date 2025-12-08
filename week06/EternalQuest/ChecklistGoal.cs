using System.Runtime;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal (string shortName, string description, int points, bool isComplete, int target, int bonus, int amountCompleted) : base (shortName, description, points, isComplete)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- {_points} points plus {_bonus} when all {_target} completed -- Current completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_isComplete},{_amountCompleted}";
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            _isComplete = true;
            return _isComplete;
        }
        else
        _isComplete = false;
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1; 
    }

    public override int GetPoints()
    {
        int bonus = _bonus;
        int points = _points;
        if (_amountCompleted == _target)
        {
            return bonus + points;
        }
        else
        return points;
    } 
}