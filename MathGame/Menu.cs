namespace MathGame
{
    internal class Menu
    {
        public static void Display(string name, DateTime date)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}.");
            Console.WriteLine("Welcome to your math game.");
            Console.WriteLine(@"Please choose a game from the options below:
            A - Addition
            S - Subtraction
            M - Multiplication
            D - Division
            Q - Quit the program
            ");
            Console.WriteLine("------------------------------------------");
        }
    }
}
