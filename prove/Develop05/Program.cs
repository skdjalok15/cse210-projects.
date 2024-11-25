using System;

class Program
{
    static GoalManager goalManager = new GoalManager();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. Record an Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    goalManager.SaveGoals("goals.txt");
                    break;
                case "5":
                    goalManager.LoadGoals("goals.txt");
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (choice)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter the target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        goalManager.AddGoal(goal);
        Console.WriteLine("Goal created successfully!");
    }

    static void RecordEvent()
    {
        Console.WriteLine("\nSelect a Goal to Record Progress:");
        var goals = goalManager.GetGoals();

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        Console.Write("Your choice: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        goalManager.RecordEvent(choice);
    }
}
