namespace MathGame
{
    internal class Game
    {
        public List<int> History { get; set; } = [];
        public bool PlayGame { get; set; } = true;
        public string Name { get; set; } = "";
        public DateTime Date { get; set; } = DateTime.UtcNow;

        private string Play()
        {
            if (History.Count > 0)
            {
                Console.WriteLine("Previous scores:");
                Console.WriteLine(string.Join(", ", History));
                Thread.Sleep(3000);
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
                    History.Add(GameEngine.AdditionGame());
                    break;
                case "s":
                    History.Add(GameEngine.SubtractionGame());
                    break;
                case "m":
                    History.Add(GameEngine.MultiplicationGame());
                    break;
                case "d":
                    History.Add(GameEngine.DivisionGame());
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

            return playAgain;
        }

        public void Loop()
        {
            while (PlayGame)
            {
                Play();
            }
        }
    }
}
