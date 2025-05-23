using Pastel;

public class TodoList()
{
    public static string[] tasks = new string[10];
    public static int taskCounter;

    public static void Complete()
    {
        Console.WriteLine("Current tasks:");
        View();
        Console.WriteLine("Enter number of the task that you would like to complete");
        int taskNumber = int.Parse(Console.ReadLine() ?? "") - 1;
        if (ValidateTaskNumber(taskNumber))
        {
            tasks[taskNumber] += " - ".Pastel(ConsoleColor.DarkGreen) + "completed".Pastel(ConsoleColor.White);
        }
        else
        {
            Console.WriteLine("Invalid number");
            Complete();
        }
    }

    public static void Add()
    {
        Console.WriteLine("Enter a task: ".Pastel(ConsoleColor.DarkBlue));
        tasks[taskCounter] = Console.ReadLine() ?? "";
        taskCounter++;
    }

    public static void View()
    {
        Console.WriteLine("======================".Pastel(ConsoleColor.Blue));
        for (int i = 0; i < taskCounter; i++)
        {
            Console.WriteLine(i + 1 + " " + tasks[i].Pastel(ConsoleColor.Blue));
        }
    }

    public static bool ValidateTaskNumber(int taskNumber)
    {
       return taskNumber >= 0 && taskNumber - 1 < taskCounter;
    }
}