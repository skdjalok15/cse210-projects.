public class ChecklistGoal : Goal
{
    private int _currentProgress;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _currentProgress = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override string DisplayStatus()
    {
        string completionStatus = _currentProgress >= _targetCount ? "[X]" : "[ ]";
        return $"{completionStatus} {Name} ({Description}) - Progress: {_currentProgress}/{_targetCount}";
    }

    public override void RecordEvent()
    {
        if (_currentProgress < _targetCount)
        {
            _currentProgress++;
            System.Console.WriteLine($"You earned {Points} points!");
            if (_currentProgress == _targetCount)
            {
                System.Console.WriteLine($"Goal completed! You earned a bonus of {_bonusPoints} points!");
            }
        }
        else
        {
            System.Console.WriteLine("Goal already completed.");
        }
    }
}
