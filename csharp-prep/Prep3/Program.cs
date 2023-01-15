using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "y";
        while (play == "y")
        {
        // Console.WriteLine("What is the magic number?");
        // string input = Console.ReadLine();
        // int number = int.Parse(input);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 500);
        int guess;
        Console.WriteLine("Let's play a game!");
        Console.WriteLine("Can you guess the Magic Number?");
        int attempts = 0;
        do
        {
            Console.Write("What is your guess? ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);
            attempts++;
            if (guess == number)
            {
                Console.WriteLine("That's right! Well done!");
                Console.WriteLine($"It took you {attempts} attempts");
                Console.WriteLine("Do you want to play again? (y/n): ");
                play = Console.ReadLine();
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
                        
        } while (guess != number);
        }
        Console.WriteLine("Thank you for playing.");
        
    }
}