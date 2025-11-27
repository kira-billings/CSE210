
class ReflectActivity : Activity
{
    private List<string> _questions; 
    private List<string> _prompts;
    public ReflectActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void RunActivity()
    {
        
    }
    public string GetRandomPrompt()
    {
        string somePrompt = "something";
        return somePrompt;
    }
    public string GetRandomQuestion()
    {
        string something = "";
        return something;
    }
    public void DisplayPrompt()
    {
        
    }
    public void DisplayQuestion()
    {
        
    }
}