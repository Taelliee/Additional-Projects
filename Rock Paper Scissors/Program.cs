using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.Write("Choose rock[r], paper[p] or scissors[s]...");
            string input = Console.ReadLine();

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computersChoice = null;
            string playersChoice;

            switch (computerRandomNumber)
            {
                case 1:
                    computersChoice = Rock; break;
                case 2:
                    computersChoice = Paper; break;
                case 3:
                    computersChoice = Scissors; break;
            }

            if (input.ToLower() == "rock" || input.ToLower() == "r")
            {
                playersChoice = Rock;
            }
            else if (input.ToLower() == "paper" || input.ToLower() == "p")
            {
                playersChoice = Paper;
            }
            else if (input.ToLower() == "scissors" || input.ToLower() == "s")
            {
                playersChoice = Scissors;
            }
            else
            {
                Console.WriteLine("Ivalid input. Try again...");
                return;
            }

            Console.WriteLine($"The computer chose {computersChoice}.");

            if (playersChoice == computersChoice)
            {
                Console.WriteLine("The game was a draw.");
            }
            else
            {
                if (playersChoice == Rock && computersChoice == Scissors || 
                    playersChoice == Paper && computersChoice == Rock ||
                    playersChoice == Scissors && computersChoice == Paper)
                {
                    Console.WriteLine("You won!");
                }
                else
                {
                    Console.WriteLine("You lost.");
                }
            }

        }
    }
}
