using System;

namespace RockPaperScissors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool keepPlaying = false;
            do
            {
                keepPlaying = StartGame();
            } while (keepPlaying);

        }

        public static bool StartGame()
        {
            ValueTuple<int, int> health = ValueTuple.Create(100, 100);
            do
            {
                try
                {
                    string playerMove = GetPlayerMove();
                    Console.WriteLine($"You chose {playerMove}");
                    string computerMove = GetComputerMove();
                    Console.WriteLine($"Computer chose {computerMove}");
                    health = CalculateHealth(health, playerMove, computerMove);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex);
                    StartGame();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    StartGame();
                }
            } while (health.Item1 > 0 && health.Item2 > 0);
            Console.WriteLine(DetermineWinner(health));
            return ContinueOrExit();
        }

        public static string GetPlayerMove()
        {
            string playerMove;
            do
            {
                Console.WriteLine("Please choose a throw: 'rock', 'paper', or 'scissors': ");
                try
                {
                    playerMove = Console.ReadLine().Trim().ToLower();
                }
                catch (NullReferenceException ex)
                {
                    throw new NullReferenceException("Parameter cannot be null", ex);
                }
            } while (!(playerMove.Equals("rock") || playerMove.Equals("paper") || playerMove.Equals("scissors")));

            return playerMove;
        }

        public static bool ContinueOrExit()
        {
            Console.WriteLine("Would you like to play again? y/n: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey(); //obtain first key pressed.
            return (keyInfo.KeyChar == 'y' || keyInfo.KeyChar == 'Y'); //continue only if 'y' is the next key pressed.
        }

        public static string GetComputerMove()
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(3);
            if (randomNumber.Equals(0))
            {
                return "rock";
            }
            else if (randomNumber.Equals(1))
            {
                return "paper";
            }
            return "scissors";
        }

        public static string DetermineWinner((int, int) health)
        {
            if (health.Item2 <= 0 && health.Item1 > 0)
            {
                return ($"You win! {health.ToString()}");
            }
            else if(health.Item2.Equals(health.Item1))
            {
                return ($"It's a draw. {health.ToString()}");
            }
            else if ((health.Item2 > 0 && health.Item1 > 0))
            {
                return ($"No winner yet. {health.ToString()}");
            }
            return ($"Sorry, you lost. {health.ToString()}");
        }


        public static ValueTuple<int, int> CalculateHealth((int, int) health, string playerMove, string computerMove)
        {
            if (playerMove == null)
            {
                throw new ArgumentNullException(nameof(playerMove));
            }
            switch (playerMove)
            {
                case "rock":
                    {
                        if (computerMove.Equals("paper"))
                        {
                            health.Item1 -= 10;
                            Console.WriteLine(health);
                            return health;
                        }
                        else if (computerMove.Equals("scissors"))
                        {
                            health.Item2 -= 20;
                            Console.WriteLine(health);
                            return health;
                        }
                        Console.WriteLine(health);
                        return health;
                    }
                case "paper":
                    {

                        if (computerMove.Equals("rock"))
                        {
                            health.Item2 -= 10;
                            Console.WriteLine(health);
                            return health;
                        }
                        else if (computerMove.Equals("scissors"))
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

                        if (computerMove.Equals("rock"))
                        {
                            health.Item1 -= 20;
                            Console.WriteLine(health);
                            return health;
                        }
                        else if (computerMove.Equals("paper"))
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
