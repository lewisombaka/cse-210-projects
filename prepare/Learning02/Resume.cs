public class Resume
{
    public string _name;
    public List<Job> _job;

    public void DisplayJobDetails()
    {
        Console.WriteLine ( $"Name: {_name}");
        Console.WriteLine ($"Jobs: ");
        foreach (Job job in _job)
        {
            job.DisplayJobDetails();
        }
    }

}