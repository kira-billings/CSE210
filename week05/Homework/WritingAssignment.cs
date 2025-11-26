
public class WritingAssignment : Assignment
{
    private string _title = "";
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _studentName = studentName;
        _topic = topic;
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"Title: {_title}";
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
}