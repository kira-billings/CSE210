public class EternalGoal : Goal
{
    // no members for EternalGoal
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
    }

    public override string GetDetailsString()
    {
        return "string";
    }

    public override string GetStringRepresentation()
    {
        return "string";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        
    }
}