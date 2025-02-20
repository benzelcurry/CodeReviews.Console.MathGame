namespace MathGame
{
    internal class GameEngine
    {
        public static int AdditionGame()
        {
            Console.WriteLine("Addition game selected.");

            int score = 0;
            var random = new Random();

            for (int i = 0; i < 5; i++)
            {
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. :(");
                }
            }

            Console.WriteLine($"Game over. Final score: {score}");

            return score;
        }

        public static int SubtractionGame()
        {
            Console.WriteLine("Subtraction game selected.");

            int score = 0;
            var random = new Random();

            for (int i = 0; i < 5; i++)
            {
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. :(");
                }
            }

            Console.WriteLine($"Game over. Final score: {score}");

            return score;
        }

        public static int MultiplicationGame()
        {
            Console.WriteLine("Multiplication game selected.");

            int score = 0;
            var random = new Random();

            for (int i = 0; i < 5; i++)
            {
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. :(");
                }
            }

            Console.WriteLine($"Game over. Final score: {score}");

            return score;
        }

        public static int DivisionGame()
        {
            Console.WriteLine("Division game selected.");

            int score = 0;
            var random = new Random();

            for (int i = 0; i < 5; i++)
            {
                int firstNumber = random.Next(0, 101);
                int secondNumber = random.Next(1, 11);

                while (firstNumber % secondNumber != 0)
                {
                    firstNumber = random.Next(0, 101);
                    secondNumber = random.Next(1, 11);
                }

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();


                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. :(");
                }
            }

            return score;
        }
    }
}
