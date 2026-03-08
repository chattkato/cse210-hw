using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the grade from the user
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        
    
        string gradeLetter = "";
        
        
        if (percent >= 90)
        {
            gradeLetter = "A";
        }
        else if (percent >= 80)
        {
            gradeLetter = "B";
        }
        else if (percent >= 70)
        {
            gradeLetter = "C";
        }
        else if (percent >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
        
        
        string plusMinus = "";
        int remainder = percent % 10;
        
        
        if (gradeLetter != "F")
        {
            if (remainder >= 7)
            {
                plusMinus = "+";
            }
            else if (remainder <= 2)
            {
                plusMinus = "-";
            }
        }
        
        
        if (gradeLetter == "A" && plusMinus == "+")
        {
            plusMinus = "";
        }
        
        
        if (gradeLetter == "F")
        {
            plusMinus = "";
        }
        
        
        Console.WriteLine("Your grade is: " + gradeLetter + plusMinus);
        
        
        if (percent >= 70)
        {
            Console.WriteLine("Good job! You passed the class.");
        }
        else
        {
            Console.WriteLine("You didn't pass this time. Keep trying!");
        }
    }
}