using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // 1. Implemented spinner animation for better user experience.
        // 2. Used proper object-oriented design with inheritance and encapsulation.
        // 3. Eliminated code duplication by placing shared logic in the base Activity class.
        // 4. Added countdown timers for guided interaction in activities.
        // 5. Structured program to be easily extendable with additional activities in the future.

        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("\nSelect a choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    new BreathingActivity().Run();
                    break;
                case 2:
                    new ReflectionActivity().Run();
                    break;
                case 3:
                    new ListingActivity().Run();
                    break;
            }
        }
    }
}