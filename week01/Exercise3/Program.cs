using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("Guess the Number from 1 - 100");
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);


        int magicGuess = -1;


        while (magicGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string mGuess = Console.ReadLine();
            magicGuess = int.Parse(mGuess);

            if (magicGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (magicGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}