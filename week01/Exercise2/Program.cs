using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Number: ")
        string valuefromuser = Console.ReadLine();

        int x = int.Parse(valuefromuser);
        int y = 2;

        if (x > y)
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Less");
}
        else
        {
            Console.WriteLine("Equal");
        }
        }
        }