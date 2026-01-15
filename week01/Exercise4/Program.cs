using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Please Enter a number: ");
            string uN = Console.ReadLine();

            userNumber = int.Parse(uN);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int count = 0;
        float sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
            count += 1;
        }

        float averageNumber = sum / count;


        int largestN = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largestN)
            {
                largestN = number;
            }
        }


        Console.WriteLine($"Total Sum of Number {sum}");
        Console.WriteLine($"The average number is {averageNumber}");
        Console.WriteLine($"The largest number is: {largestN}");
    }
}