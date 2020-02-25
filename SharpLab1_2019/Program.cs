using System;

namespace SharpLab1_2019
{
    class Program
    {
        enum Action
        {
            Rock,
            Paper,
            Scisors
        }

        static Action Roll()
        {
            Action action = (Action)(new Random()).Next(0, 3);
            return action;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome, to the Rock-Paper-Scisors the Game.");
            Console.WriteLine("\n Enter the number of rounds u wanna play...");
            int n = Int32.Parse(Console.ReadLine());
            int i = 0, playerScore = 0, opponentScore = 0;
            while (i < n)
            {
                Console.WriteLine("\nBeginning of the round. Choose simbol: 0 - Scissors; 1 - Rock; 2 - Paper.");
                Action playerAction = (Action)Enum.Parse(typeof(Action), Console.ReadLine());
                Action opponentAction = Roll();
                switch (playerAction)
                {
                    case Action.Scisors:
                        {
                            if (opponentAction == Action.Scisors)
                            {
                                Console.WriteLine("\nYgh... It's a Draw.");
                                playerScore += 0;
                                opponentScore += 0;
                            }
                            if (opponentAction == Action.Rock)
                            {
                                Console.WriteLine("\nSorry, you lost...");
                                opponentScore++;
                            }
                            if (opponentAction == Action.Paper)
                            {
                                Console.WriteLine("\nCongratulations! You win!");
                                playerScore++;
                            }
                            i++;
                            break;
                        }
                    case Action.Rock:
                        {
                            if (opponentAction == Action.Scisors)
                            {
                                Console.WriteLine("\nCongratulations! You win!");
                                playerScore++;
                            }
                            if (opponentAction == Action.Rock)
                            {
                                Console.WriteLine("\nYgh... It's a Draw.");
                                playerScore += 0;
                                opponentScore += 0;
                            }
                            if (opponentAction == Action.Paper)
                            {
                                Console.WriteLine("\nSorry, you lost...");
                                opponentScore++;
                            }
                            i++;
                            break;
                        }
                    case Action.Paper:
                        {
                            if (opponentAction == Action.Scisors)
                            {
                                Console.WriteLine("\nSorry, you lost...");
                                opponentScore++;
                            }
                            if (opponentAction == Action.Rock)
                            {
                                Console.WriteLine("\nCongratulations! You win!");
                                playerScore++;
                            }
                            if (opponentAction == Action.Paper)
                            {
                                Console.WriteLine("\nYgh... It's a Draw.");
                                playerScore += 0;
                                opponentScore += 0;
                            }
                            i++;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nThere is no such simbol. Don't test me child!");
                            break;
                        }
                }
            }
            Console.Write("\n\nCount: You:{0} Opponent:{1}", playerScore, opponentScore);
            if (playerScore > opponentScore)
            {
                Console.WriteLine("\nCongratulations! You win the Game!");
            }
            if (playerScore == opponentScore)
            {
                Console.WriteLine("\nDraw. Good enough.");
            }
            if (playerScore < opponentScore)
            {
                Console.WriteLine("\nSorry, you lost the Game...");
            }
            if (playerScore == 0 && opponentScore == 0)
            {
                Console.WriteLine("\nDon't test me child");
            }
            Console.Write("\n\nPress any to exit...");
            Console.ReadKey(true);
        }
    }
}
