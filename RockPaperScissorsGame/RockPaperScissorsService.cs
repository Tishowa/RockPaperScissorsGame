using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    internal class RockPaperScissorsService
    {
        public static GameResult DefineTheGameResult(int choicePlayer1, int choicePlayer2, GameResult gameResult)
        {
            int scorePlayer = gameResult.GetScorePlayer1();
            int scoreCPU = gameResult.GetScorePlayer2();

            switch (choicePlayer2)
            {
                case 1:
                    if (choicePlayer1 == 1)
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (choicePlayer1 == 2)
                    {
                        Console.WriteLine("PLAYER 1 WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (choicePlayer1 == 3)
                    {
                        Console.WriteLine("Player 2 WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 2:
                    if (choicePlayer1 == 2)
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (choicePlayer1 == 1)
                    {
                        Console.WriteLine("Player 2 WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (choicePlayer1 == 3)
                    {
                        Console.WriteLine("PLAYER 1 WINS!!\n\n");
                        scorePlayer++;
                    }
                    break;
                case 3:
                    if (choicePlayer1 == 3)
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (choicePlayer1 == 1)
                    {
                        Console.WriteLine("PLAYER 1 WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (choicePlayer1 == 2)
                    {
                        Console.WriteLine("PLAYER 2 WINS!!\n\n");
                        scoreCPU++;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid entry!");
                    break;
            }
            gameResult.SetScorePlayer1(scorePlayer);
            gameResult.SetScorePlayer2(scoreCPU);
            return gameResult;
        }

        public static void WhoIsTheWinner(GameResult gameResult) {
            if (gameResult.GetScorePlayer1() == 3)
            {
                Console.WriteLine("Player 1 WON!");
            }
            else if (gameResult.GetScorePlayer2() == 3)
            {
                Console.WriteLine("Player 2 WON!");
            }
        }
        
        public static int SetComputerNextChoice(int computerChoice)
        {
            //set computer choice based on the previous one
            if (computerChoice == 1)
            {
                return 2;
            }
            else if (computerChoice == 2)
            {
                return 3;
            }
            else if (computerChoice == 3)
            {
                return 1;
            }
            else
            {
                return new Random().Next(1, 4);
            }
        }

        public static int ConvertUserInputStringToInt(string userInput)
        {
            if (userInput?.ToLower() == "rock") { return 1; }
            else if (userInput?.ToLower() == "paper") { return 2; }
            else if (userInput?.ToLower() == "scissors") { return 3; }
            else return 0;
        }
    }
}
