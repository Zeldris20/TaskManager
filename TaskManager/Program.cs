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

        taskManager.ListTasks();

        // Ask the user if they want to add a task
        Console.Write("\nDo you want to add a task? (y/n) ");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y")
        {
            Console.Write("Enter task description: ");
            string userTaskDescription = Console.ReadLine();
            taskManager.AddTask(userTaskDescription);
        }
        

        taskManager.ListTasks();
    }
}
