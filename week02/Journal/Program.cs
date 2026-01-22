// In lines 13 - 18 and 42 = I simply made the interaction with the user more friendly by asking the name. And displaying the name in parts where it matters. 
using System;

class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Welcome To Your Own Personal Journal!");

        string name;
        Console.Write("What is your name? ");
        name = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Hi {name}");
        Console.WriteLine("Please select one of the following choices:\n1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");
        Console.Write("What number would you choose? ");

        Journal userJournal = new Journal();
        PromptGenerator generatePrompt = new PromptGenerator();

        int choice = int.Parse(Console.ReadLine());
        while (choice != 5)
        {


            if (choice == 1)
            {
                Entry newEntry = new Entry();
                newEntry._promptText = generatePrompt.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                newEntry._entryText = Console.ReadLine();

                userJournal.AddEntry(newEntry);
            }

            else if (choice == 2)
            {
                Console.WriteLine($"Hi {name} Here is(are) your entries.");
                userJournal.DisplayAll();
                Console.WriteLine();
            }

            else if (choice == 3)
            {

                Console.WriteLine("What is the name of your Journal?");
                string fileName = Console.ReadLine();
                userJournal.LoadFromFile($"{fileName}.txt");
            }

            else if (choice == 4)
            {
                Console.WriteLine("What is the name of your Journal?");
                string fileName = Console.ReadLine();
                userJournal.SaveToFile($"{fileName}.txt");
            }

            else
            {
                Console.WriteLine("Please input only numbers 1 - 5");
            }


            Console.WriteLine("Please select one of the following choices:\n1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            Console.Write("What number would you choose? ");
            choice = int.Parse(Console.ReadLine());
        }
    }
}