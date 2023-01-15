using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (To quit enter 0): ");
            string input = Console.ReadLine();
            userNumber = int.Parse(input);
            if (userNumber != 0)
            {
            numbers.Add(userNumber);
            }
        }
        Console.WriteLine("The numbers you entered are:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        // the sum of the numbers //
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum is: {sum}");

        int average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max number in the list was {max}");
        
        
    }
}