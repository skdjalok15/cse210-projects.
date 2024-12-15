using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Activity running = new Running("03 Nov 2022", 30, 3.0);
        Activity cycling = new Cycling("04 Nov 2022", 40, 15.0);
        Activity swimming = new Swimming("05 Nov 2022", 25, 20);

        // Add to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
