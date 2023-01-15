using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name?: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber ()
        {
            Console.Write("What is your favotite number?: ");
            string input = Console.ReadLine();
            int userNumber = int.Parse(input);
            return userNumber;
        }
        static int SquareNumber(int number)
        {
            int squared = number * number;
            return  squared;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);

    }
}