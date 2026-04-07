using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
        "Relax by slowly breathing in and out.")
    {
    }

    public void Run()
    {
        Start();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);

            Console.Write("\nHold... ");
            ShowCountdown(2);

            Console.Write("\nBreathe out... ");
            ShowCountdown(4);
        }

        End();
    }
}