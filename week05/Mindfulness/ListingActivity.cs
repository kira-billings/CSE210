
class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
      public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void RunActivity()
    {
        
    }
    public void GetRandomPrompt()
    {
        
    }
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        return userList;
    }
}