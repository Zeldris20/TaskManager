using System;

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        while (true)
        {
            taskManager.ListTasks();

            // Ask the user if they want to add a task
            Console.Write("\nDo you want to add a task? (y/n) ");
            string userResponse = Console.ReadLine().ToLower();
            if (userResponse == "y")
            {
                Console.Write("Enter task description: ");
                string userTaskDescription = Console.ReadLine();
                taskManager.AddTask(userTaskDescription);
            }

            taskManager.ListTasks();

            // Ask the user if they want to mark a task as complete
            Console.Write("\nDo you want to mark a task as complete? (y/n) ");
            userResponse = Console.ReadLine().ToLower();

            if (userResponse == "y")
            {
                Console.Write("Enter task number to mark as completed: ");
            
                if (int.TryParse(Console.ReadLine(), out int taskId))
                {
                    taskManager.MarkTaskAsComplete(taskId);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid task number.");
                }
            }

            taskManager.ListTasks();

            // Ask the user if they want to rename a task
            Console.Write("\nDo you want to rename a task? (y/n) ");
            userResponse = Console.ReadLine().ToLower();
            if (userResponse == "y")
            {
                Console.Write("Enter task number to rename: ");
                if (int.TryParse(Console.ReadLine(), out int taskId))
                {
                    Console.Write("Enter new task description: ");
                    string newDescription = Console.ReadLine();
                    taskManager.RenameTask(taskId, newDescription);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid task number.");
                }
            }
             // Check if the user wants to continue
            Console.Write("\nDo you want to continue? (y/n) ");
            userResponse = Console.ReadLine().ToLower();

            if (userResponse != "y")
            {
             break;
            }
        }
            Console.WriteLine("Task Manager is full. Delete some tasks to continue.");
            Console.ReadLine();

        taskManager.ListTasks();
        Console.ReadLine();
    }
}
