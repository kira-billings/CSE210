
class BreatheActivity : Activity
{
      public BreatheActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void RunActivity()
    {
        DisplayStartMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in... ");
            ShowCountDown(7);      
            Console.WriteLine("Breathe out... ");
            ShowCountDown(7);
        }
        DisplayEndMessage();
    }
}