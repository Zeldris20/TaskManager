// Task.cs
public class Task
{
    public string TaskDescription { get; set; }
    public bool IsCompleted { get; set; }

    // Constructor with parameters
    public Task(string description, bool isCompleted)
    {
        TaskDescription = description;
        this.IsCompleted = isCompleted;
    }
}