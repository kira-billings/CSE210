
public class Resume
{
    public string _memberName;

    public List<Job> _jobList = new List<Job>();

    public void DisplayMyResume()
    {
        Console.WriteLine(_memberName);
        foreach (Job itemJob in _jobList)
        {
            itemJob.DisplayJobDetails();
        }
    }
}