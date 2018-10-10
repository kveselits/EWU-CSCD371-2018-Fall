using System;
using System.Runtime.CompilerServices;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = false;
            do
            {
                StartGame();
            } while (keepPlaying);

        }

        private static bool StartGame()
        {
            ValueTuple<int, int> health = ValueTuple.Create(100, 100);
            do
            {
                Console.WriteLine("rock, paper, or scissors: ");
                string move = Console.ReadLine();
                health = SelectMove(health, move);
            } while (health.Item1 > 0 && health.Item2 > 0);
            Console.WriteLine(DetermineWinner(health));
            Console.WriteLine("Would you like to play again? y/n: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey(); //obtain first key pressed.
            return keyInfo.KeyChar == 'y'; //continue only if user selects y.
        }

        private static string DetermineWinner((int, int) health)
        {
            if (health.Item1 <= 0)
                return ($"You win! {health.ToString()}");
            return ($"Sorry, you lost. {health.ToString()}");
        }


        private static ValueTuple<int, int> SelectMove((int, int) health, string move)
        {
            Random randomNumber = new Random();
            switch (move)
            {
                case "rock":
                    {
                        int num = randomNumber.Next(3);
                        Console.WriteLine(num);
                        if (num.Equals(1))
                        {
                            health.Item1 -= 10;
                            Console.WriteLine(health);
                            return health;
                        }
                        else if (num.Equals(2))
                        {
                            health.Item2 -= 15;
                            Console.WriteLine(health);
                            return health;
                        }
                        Console.WriteLine(health);
                        return health;
                    }
                case "paper":
                    {
                        int num = randomNumber.Next(3);
                        Console.WriteLine(num);

                        if (num.Equals(0))
                        {
                            health.Item2 -= 10;
                            Console.WriteLine(health);
                            return health;
                        }
                        else if (num.Equals(2))
                        {
                            health.Item1 -= 15;
                            Console.WriteLine(health);
                            return health;
                        }
                        Console.WriteLine(health);
                        return health;
                    }
                case "scissors":
                    {
                        int num = randomNumber.Next(3);
                        Console.WriteLine(num);

                        if (num.Equals(0))
                        {
                            health.Item1 -= 20;
                            Console.WriteLine(health);
                            return health;
                        }
                        else if (num.Equals(1))
                        {
                            health.Item2 -= 15;
                            Console.WriteLine(health);
                            return health;
                        }
                        Console.WriteLine(health);
                        return health;
                    }
            }
            return health;
        }
    }
}
