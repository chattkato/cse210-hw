using System;

/*
CREATIVITY EXPLANATION:
This program exceeds requirements by adding:
1. Level system (based on score)
2. Title system (Beginner, Disciple, Warrior, Master)
3. Streak bonus (extra points after 3 consecutive goal completions)

These features enhance gamification and user motivation.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            manager.DisplayScore();

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("1. Simple  2. Eternal  3. Checklist");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                    manager.AddGoal(new SimpleGoal(name, desc, points));

                else if (type == "2")
                    manager.AddGoal(new EternalGoal(name, desc, points));

                else if (type == "3")
                {
                    Console.Write("Target: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.AddGoal(new ChecklistGoal(name, desc, points, 0, target, bonus));
                }
            }
            else if (choice == "2")
            {
                manager.DisplayGoals();
            }
            else if (choice == "3")
            {
                manager.DisplayGoals();
                Console.Write("Select goal #: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                manager.RecordGoal(index);
            }
            else if (choice == "4")
            {
                Console.Write("Filename: ");
                manager.Save(Console.ReadLine());
            }
            else if (choice == "5")
            {
                Console.Write("Filename: ");
                manager.Load(Console.ReadLine());
            }
            else if (choice == "6")
            {
                break;
            }
        }
    }
}