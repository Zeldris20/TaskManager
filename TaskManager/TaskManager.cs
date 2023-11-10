using System;
using System.Collections.Generic;

class TaskManager
{
    private List<Task> tasks;

    public TaskManager()
    {
        tasks = new List<Task>();
    }

    public void AddTask(string description)
    {
        Task newTask = new Task(description, false);
        tasks.Add(newTask);
        Console.WriteLine($"Task added: {newTask.TaskDescription}");
        CheckAndDeleteTask();
    }

    public void ListTasks()
    {
        Console.WriteLine("Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
           string status = tasks[i].IsCompleted ? "[Completed]" : "[Not Completed]";
        Console.WriteLine($"{i + 1}. {status} {tasks[i].TaskDescription}");
        }
    }

    public void MarkTaskAsComplete(int taskNumber)
    {
        if (taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks[taskNumber - 1].IsCompleted = true;
            Console.WriteLine($"Task {taskNumber} marked as completed.");
            CheckAndDeleteTask();
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }

    public void RenameTask(int taskNumber, string newDescription)
    {
        if (taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks[taskNumber - 1].TaskDescription = newDescription;
            Console.WriteLine($"Task {taskNumber} renamed to: {newDescription}");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
    public bool IsFull()
    {
        return tasks.Count >= 7;
    }

    private void CheckAndDeleteTask()
    {
        if (tasks.Count >= 7)
        {
            Task completedTask = tasks.Find(t => t.IsCompleted);
            if (completedTask != null)
            {
                tasks.Remove(completedTask);
                Console.WriteLine($"Task '{completedTask.TaskDescription}' deleted after completion.");
            }
        }
    }
}
