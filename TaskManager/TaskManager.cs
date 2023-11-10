// TaskManager.cs
using System;
using System.Collections.Generic;

public class TaskManager
{
    private List<Task> tasks;

    public TaskManager()
    {
        tasks = new List<Task>();
    }

    public void AddTask(string description)
    {
        int taskId = tasks.Count + 1;
        Task newTask = new Task { Id = taskId, Description = description, IsComplete = false };
        tasks.Add(newTask);
    }

    public void MarkTaskAsComplete(int taskId)
    {
        Task task = tasks.Find(t => t.Id == taskId);
        if (task != null)
        {
            task.IsComplete = true;
        }
    }

    public void ListTasks()
    {
        Console.WriteLine("Tasks:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"[{task.Id}] {task.Description} - {(task.IsComplete ? "Complete" : "Incomplete")}");
        }
    }

    public void MarkTaskAsComplete(int taskNumber)
{
    if (taskNumber > 0 && taskNumber <= tasks.Count)
    {
        tasks[taskNumber - 1].IsCompleted = true;
        Console.WriteLine($"Task {taskNumber} marked as completed.");
    }
    else
    {
        Console.WriteLine("Invalid task number.");
    }
}

}
