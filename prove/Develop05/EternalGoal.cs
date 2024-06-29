public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        // the Eternal Goals are forever and never ending like how we need to have these for daily living ;).
    }

    public override string DisplayProgress()
    {
        return "[FOREVER] " + Name;
    }
}
