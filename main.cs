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

        Console.WriteLine("\nMarking task 1 as complete...");
        taskManager.MarkTaskAsComplete(1);

        taskManager.ListTasks();

        Console.ReadLine(); // Keeps the console window open
    }
}
