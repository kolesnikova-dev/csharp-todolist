using Pastel;

public class Program {

    public static void Loop()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1" + " Add a task".Pastel(ConsoleColor.DarkBlue));
            Console.WriteLine("2" + " View tasks".Pastel(ConsoleColor.DarkBlue));
            Console.WriteLine("3" + " Mark a task as complete".Pastel(ConsoleColor.DarkBlue));
            Console.WriteLine("4" + " Exit".Pastel(ConsoleColor.DarkBlue));
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    TodoList.Add();
                    break;
                case "2":
                    TodoList.View();
                    break;
                case "3":
                    TodoList.Complete();
                    break;
                case "4":
                    running = false;
                    End();
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.WriteLine("======================".Pastel(ConsoleColor.Blue));
        }
    }

    public static void End()
    {
            Console.WriteLine("======================".Pastel(ConsoleColor.DarkGreen));
            Console.WriteLine("Goodbye!".Pastel(ConsoleColor.Blue));
            Console.WriteLine("======================".Pastel(ConsoleColor.DarkGreen));
    }

    public static void Greet()
    {
        Console.WriteLine("======================".Pastel(ConsoleColor.DarkGreen));
        Console.WriteLine("Welcome to CSharp List".Pastel(ConsoleColor.Blue));
        Console.WriteLine("======================".Pastel(ConsoleColor.DarkGreen));
    }
    public static void Main()
    {
        Greet();
        Loop();
    }
}
