
public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";
    public Assignment()
    {
        
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic; 
    }
    public string GetSummary()
    {
       return $"Student Name: {_studentName}\nStudent Topic: {_topic}";
    }
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
}