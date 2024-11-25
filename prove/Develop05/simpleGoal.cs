public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isCompleted = false;
    }

    public override string DisplayStatus()
    {
        return _isCompleted ? $"[X] {Name} ({Description})" : $"[ ] {Name} ({Description})";
    }

    public override void RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            System.Console.WriteLine($"You earned {Points} points!");
        }
        else
        {
            System.Console.WriteLine("Goal already completed.");
        }
    }
}
