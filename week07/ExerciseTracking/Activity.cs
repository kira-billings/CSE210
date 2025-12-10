using System.Diagnostics.Contracts;

public abstract class Activity
{
    protected string _date;
    protected int _minutes;
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public string GetDate()
    {
        return _date;
    }
    
    public int GetMinutes()
    {
        return _minutes;
    }
    public abstract float GetDistance();
    public abstract float GetPace();
    public abstract float GetSpeed();
    public abstract string GetName();
    public void GetSummary()
    {
        Console.WriteLine($"{GetDate()} {GetName()} ({GetMinutes()}) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} minutes per km");
    }
}