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
        string determination = Console.ReadLine() ?? "";
        if (int.TryParse(determination, out int taskNumber))
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
        for (int i = 0; i < tasks.Length; i++)
        {
            Console.WriteLine(i + " " + tasks[i].Pastel(ConsoleColor.Blue));
        }
    }
}