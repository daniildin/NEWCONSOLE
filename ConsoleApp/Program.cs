using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("**************");
            Console.WriteLine("\nMenu:\n");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit\n");
            Console.WriteLine("**************");
            Console.Write("Enter your choice: ");

            string? choice = Console.ReadLine();

            if (string.IsNullOrEmpty(choice))
                continue;

            if (choice == "4")
            {
                Console.WriteLine("Quitting the application. Goodbye!");
                break;
            }
        }
    }
}