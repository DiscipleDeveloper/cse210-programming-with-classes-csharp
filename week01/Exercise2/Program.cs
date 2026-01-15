using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string sGpercentage = Console.ReadLine();
        int gradePercent = int.Parse(sGpercentage);

        string letter = "";

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is {letter}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You Passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed.");
        }
    }
}