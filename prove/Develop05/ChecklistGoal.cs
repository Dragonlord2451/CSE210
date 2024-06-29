public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int requiredTimes;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int requiredTimes, int bonusPoints) 
        : base(name, points)
    {
        this.requiredTimes = requiredTimes;
        this.bonusPoints = bonusPoints;
        this.timesCompleted = 0;
    }

    public int TimesCompleted => timesCompleted;

    public override void RecordEvent()
    {
        if (timesCompleted < requiredTimes)
        {
            timesCompleted++;
            if (timesCompleted == requiredTimes)
            {
                MarkComplete();
            }
        }
    }

    public override string DisplayProgress()
    {
        return IsCompleted ? $"[X] {Name} (Completed {timesCompleted}/{requiredTimes} times)" 
                           : $"[ ] {Name} (Completed {timesCompleted}/{requiredTimes} times)";
    }

    public int GetBonusPoints() => IsCompleted ? bonusPoints : 0;
}
