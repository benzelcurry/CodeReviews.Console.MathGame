namespace MathGame
{
    internal class Game
    {
        public List<(string, int)> History { get; set; } = [];
        public bool PlayGame { get; set; } = true;
        public string Name { get; set; } = "";
        public DateTime Date { get; set; } = DateTime.UtcNow;

        private void Play()
        {
            if (History.Count > 0)
            {
                ShowPreviousGames();
            }

            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Please enter your name:");
                Name = Console.ReadLine() ?? "Anonymous";
            }

            Menu.Display(Name, Date);

            string gameSelected = Console.ReadLine()?.Trim().ToLower() ?? "";

            switch (gameSelected)
            {
                case "a":
                    History.Add(("Addition", GameEngine.AdditionGame()));
                    break;
                case "s":
                    History.Add(("Subtraction", GameEngine.SubtractionGame()));
                    break;
                case "m":
                    History.Add(("Multiplication", GameEngine.MultiplicationGame()));
                    break;
                case "d":
                    History.Add(("Division", GameEngine.DivisionGame()));
                    break;
                case "h":
                    ShowPreviousGames();
                    break;
                default:
                    Console.WriteLine("Invalid input detected. Application closing.");
                    break;
            }

            Console.WriteLine("Would you like to play again? (Yes / No)");

            string playAgain = Console.ReadLine()?.Trim().ToLower() ?? "";

            while (playAgain != "yes" && playAgain != "no")
            {
                Console.WriteLine("Sorry, I don't understand that. Please input 'Yes' or 'No'");
                playAgain = Console.ReadLine()?.Trim().ToLower() ?? "";
            }

            PlayGame = (playAgain == "yes");
        }

        public void Loop()
        {
            while (PlayGame)
            {
                Play();
            }
        }

        private void ShowPreviousGames()
        {
            Console.WriteLine("Previous games played:\n");
            foreach ((string type, int score) game in History)
            {
                Console.WriteLine($"{game.type}: {game.score}/5");
            }
            Console.WriteLine();
            Thread.Sleep(1000);
        }
    }
}
