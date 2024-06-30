class ChecklistGoal : Goal
{
    public int CurrentCount { get; private set; }
    public int TargetCount { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                IsCompleted = true;
            }
        }
    }

    public override string GetStatus()
    {
        return $"[ChecklistGoal] {Name} - {Points} points each - Completed {CurrentCount}/{TargetCount} times - {(IsCompleted ? "[X]" : "[ ]")}";
    }
}
