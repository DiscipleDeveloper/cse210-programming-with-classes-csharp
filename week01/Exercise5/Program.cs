using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome!");
        }
        DisplayWelcome();

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            return Console.ReadLine();
        }

        string name = PromptUserName();

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }


        static int SquareNumber(int number)
        {
            return number * number;
        }

        int square = SquareNumber(PromptUserNumber());

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}.");
        }
        DisplayResult(name, square);

    }
}