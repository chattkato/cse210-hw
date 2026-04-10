using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Activity running = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        Activity cycling = new Cycling(new DateTime(2022, 11, 3), 45, 20.0);
        Activity swimming = new Swimming(new DateTime(2022, 11, 3), 25, 40);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}