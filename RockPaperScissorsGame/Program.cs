using RockPaperScissorsGame;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int inputPlayer1;
        int inputPlayer2 = 0;
        bool playAgain = true;
        string[] choices = new string[3] { "ROCK", "PAPER", "SCISSORS" };

        while (playAgain)
        {
            Console.WriteLine("Do you want to play against a computer or a player?(c/p)  ");
            string playerTypeAnswer = Console.ReadLine()?.ToLower();

            if (playerTypeAnswer != "c" && playerTypeAnswer != "p")
            {
                Console.WriteLine("Please enter c for computer or p for player");
            }
            else
            {
                GameResult gameResult = new GameResult();
                while (gameResult.GetScorePlayer1() < 3 && gameResult.GetScorePlayer2() < 3)
                {
                    Console.Write("Player 1: Choose between ROCK, PAPER and SCISSORS:    ");
                    inputPlayer1 = RockPaperScissorsService.ConvertUserInputStringToInt(Console.ReadLine());

                    //set the second player's choice
                    if (playerTypeAnswer == "c")
                    {
                        inputPlayer2 = RockPaperScissorsService.SetComputerNextChoice(inputPlayer2);
                        Console.WriteLine("Computer chose "+ choices[inputPlayer2-1]);
                    }
                    else if (playerTypeAnswer == "p")
                    {
                        Console.Write("Player 2: Choose between ROCK, PAPER and SCISSORS:    ");
                        inputPlayer2 = RockPaperScissorsService.ConvertUserInputStringToInt(Console.ReadLine());
                    }

                    //Define the round result
                    if (inputPlayer1 != 0 && inputPlayer2 != 0)
                    {
                        gameResult = RockPaperScissorsService.DefineTheGameResult(inputPlayer1, inputPlayer2, gameResult);
                        Console.WriteLine("\n\nSCORES:\tPLAYER 1:\t{0}\tPLAYER 2:\t{1}", gameResult.GetScorePlayer1(), gameResult.GetScorePlayer2());
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry!");
                    }
                }
                RockPaperScissorsService.WhoIsTheWinner(gameResult);
                Console.WriteLine("Do you want to play again?(y/n)  ");
                playAgain = Console.ReadLine() == "y" ? true : false;
            }

        }
    }
}