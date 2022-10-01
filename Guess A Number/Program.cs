using System;

namespace Guess_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);

            while (true)
            {
                Console.Write("Guess a number between 1 and 100: ");
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int guessedNumber);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (guessedNumber > computerNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guessedNumber < computerNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                
            }
        }
    }
}
