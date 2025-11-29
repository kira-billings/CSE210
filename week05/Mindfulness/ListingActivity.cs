
using System.Net;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "What are you grateful for today?"
    };
      public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    
    public void RunActivity()
    {
        DisplayStartMessage();
        Console.WriteLine();
        GetRandomPrompt();
        List<string> userList = GetListFromUser();
        _count = userList.Count;
        Console.WriteLine($"You entered {_count} items.");
        DisplayEndMessage();
    }
    public void GetRandomPrompt()
    {
        Random _rand = new Random();
        int index = _rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]); 
    }
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            userList.Add(response);
        }
        return userList;
    }
}