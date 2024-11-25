public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override string DisplayStatus()
    {
        return $"[∞] {Name} ({Description}) - {Points} points each time";
    }

    public override void RecordEvent()
    {
        System.Console.WriteLine($"You earned {Points} points!");
    }
}
