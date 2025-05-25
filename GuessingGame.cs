using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSProj
{
    public static class GuessingGame
    {
        public static  void PlayGame()
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computerChoice;
            String playOption;
            int number;
            int wins = 0, losses = 0, ties = 0;

            while (playAgain)
            {
                Console.Write("Rock, Paper or Scissors: ");
                player = Console.ReadLine();
                player = player.ToLower();
                number = random.Next(1, 100);

                if (number <= 33)
                {
                    computerChoice = "rock";
                }
                else if (number <= 66)
                {
                    computerChoice = "paper";
                }
                else
                {
                    computerChoice = "scissors";
                }

                if (player != "rock" && player != "paper" && player != "scissors")
                {
                    Console.WriteLine("Invalid option, try again.");
                }
                else
                {
                    if (player == computerChoice)
                    {
                        Console.WriteLine("It's a tie!");
                        ties++;
                    }
                    else if ((player == "rock" && computerChoice == "paper") ||
                        (player == "paper" && computerChoice == "scissors") ||
                        (player == "scissors" && computerChoice == "rock"))
                    {
                        Console.WriteLine("You lose. Try again.");
                        losses++;
                    }
                    else if ((computerChoice == "rock" && player == "paper") ||
                        (computerChoice == "paper" && player == "scissors") ||
                        (computerChoice == "scissors" && player == "rock"))
                    {
                        Console.WriteLine("You win.");
                        wins++;
                    }
                    else
                    {
                        Console.WriteLine("Are you fucking retarded?");
                    }


                    Console.Write($"Wins: {wins} Losses: {losses} Ties: {ties}\nPlay again? (y/n): ");
                    playOption = Console.ReadLine();
                    if (playOption.ToLower() == "n")
                    {
                        playAgain = false;
                    }
                    else if (playOption.ToLower() == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        Console.Write("Invalid option. Exiting now.");
                        break;
                    }

                }

            }

        }
    }
}
