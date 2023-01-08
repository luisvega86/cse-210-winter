using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);
        string grade;
        string sign;
        if ( number >= 90)
        {
            grade = "A";
        }
        else if ( number >= 80)
        {
            grade = "B";
        }
        else if ( number >= 70)
        {
            grade = "C";
        }
        else if ( number > 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        if ( (number % 10) < 4)
        {
            sign = "-";
        }
        else if ( (number % 10) >= 7)
        {
            sign = "+";
        }
        else
        {
            sign = "";
        }
        if ( (number % 10) >= 4)
        {
            if (grade == "A")
            {
                sign = "";
            }
        }
        if (grade == "D")
        {
            sign = "";
        }


        Console.WriteLine($"Your grade is {sign}{grade}");
        if ( number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
            
        }
        if ( number < 70)
        {
            Console.WriteLine("Sorry! Try again next semester.");
            
        }
        
    }
}