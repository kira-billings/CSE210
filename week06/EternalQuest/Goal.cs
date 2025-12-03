using System.ComponentModel;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string shortName, string description, int points)
    {
        
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}