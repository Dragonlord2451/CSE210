public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            MarkComplete();
        }
    }

    public override string DisplayProgress()
    {
        return IsCompleted ? "[X] " + Name : "[ ] " + Name;
    }
}
