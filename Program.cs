// Program.cs
using System;

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        // Example usage
        taskManager.AddTask("Create a simple project in C#");
        taskManager.AddTask("Learn Git basics");
        taskManager.AddTask("Push changes to GitHub");

        Console.WriteLine("Tasks: ");

        // Allow the user to add tasks
        Console.Write("Enter a new Task: ");
        string userTaskDescription = Console.ReadLine();
        taskManager.AddTask(userTaskDescription);

        // Display tasks including the user-added task
        taskManager.ListTasks();
        // Allow the user to delete tasks
        Console.Write("Enter the task number to delete: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumberToDelete))
        {
            taskManager.DeleteTask(taskNumberToDelete);
        }
        // Display tasks after deletion
        taskManager.ListTasks();

        Console.ReadLine(); // Wait for user to press enter
    }
}
