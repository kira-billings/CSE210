public class EternalGoal : Goal
{
    // no members for EternalGoal
    public EternalGoal(string shortName, string description, int points, bool isComplete) : base(shortName, description, points, isComplete)
    {
        
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- {_points} points";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
    }
    public override int GetPoints()
    {
        int points = _points;
        return points;
    }
}