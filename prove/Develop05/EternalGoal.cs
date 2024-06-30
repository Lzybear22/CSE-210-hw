class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        // Eternal goals are never marked as completed
    }

    public override string GetStatus()
    {
        return $"[EternalGoal] {Name} - {Points} points - [ ]";
    }
}
