public class Swimming : Activity
{
    private float _laps;
    
    public Swimming(string date, int minutes, float laps) : base(date, minutes) 
    {
        _laps = laps;
    }
    public override float GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override float GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }
    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetName()
    {
        return "Swimming";
    }
}