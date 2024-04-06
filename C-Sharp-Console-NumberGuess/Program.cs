using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console_NumberGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectNumber = false;
            Random number = new Random();

            int randomNum = number.Next(1,11);

            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("A number between 1 and 10 will be generated.");
            Console.WriteLine("If you guess the correct number, you win");


            while (!isCorrectNumber)
            {

                Console.WriteLine("Please enter your Guess:");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randomNum)
                {
                    Console.WriteLine("You Win! You guessed the right number!");
                    isCorrectNumber = true;
                } 
                else if (guess>randomNum) 
                {
                    Console.WriteLine("Your guess is high");
                }
                else if(randomNum > guess)
                {
                    Console.WriteLine("Your guess is low");
                }
            }
            Console.ReadKey();
        }
    }
}
