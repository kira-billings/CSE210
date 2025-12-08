public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points, bool isComplete) : base(shortName, description, points, isComplete)
    {
        _isComplete = isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- {_points} points";
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override int GetPoints()
    {
        int points = _points;
        return points;
    }
}