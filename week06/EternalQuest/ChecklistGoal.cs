public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string shortName, string description, int points, int target, int bonus) : base (shortName, description, points )
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