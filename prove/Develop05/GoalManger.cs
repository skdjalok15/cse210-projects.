using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            Console.WriteLine("Event recorded!");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                string goalData = SerializeGoal(goal);
                writer.WriteLine(goalData);
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                Goal goal = DeserializeGoal(line);
                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("Save file not found.");
        }
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    private string SerializeGoal(Goal goal)
    {
        if (goal is SimpleGoal simpleGoal)
        {
            return $"Simple,{simpleGoal.Name},{simpleGoal.Description},{simpleGoal.Points},{simpleGoal.DisplayStatus().Contains("[X]")}";
        }
        else if (goal is EternalGoal eternalGoal)
        {
            return $"Eternal,{eternalGoal.Name},{eternalGoal.Description},{eternalGoal.Points}";
        }
        else if (goal is ChecklistGoal checklistGoal)
        {
            return $"Checklist,{checklistGoal.Name},{checklistGoal.Description},{checklistGoal.Points},{checklistGoal.DisplayStatus().Contains("[X]")},{checklistGoal.GetHashCode()}";
        }
        return string.Empty;
    }

    private Goal DeserializeGoal(string data)
    {
        string[] parts = data.Split(',');
        string type = parts[0];
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);

        switch (type)
        {
            case "Simple":
                bool isCompleted = bool.Parse(parts[4]);
                var simpleGoal = new SimpleGoal(name, description, points);
                if (isCompleted) simpleGoal.RecordEvent();
                return simpleGoal;

            case "Eternal":
                return new EternalGoal(name, description, points);

            case "Checklist":
                int currentProgress = int.Parse(parts[4]);
                int targetProgress = int.Parse(parts[5]);
                return new ChecklistGoal(name, description, points, currentProgress, targetProgress);

            default:
                return null;
        }
    }
}
