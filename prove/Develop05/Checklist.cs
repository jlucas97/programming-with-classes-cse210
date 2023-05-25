
class Checklist : Goal
{
    protected int _bonusTimes;
    protected int _bonusPoints;
    protected int _eventsRecorded;

    public Checklist(string goal, string description, int points, int bonusTimes, int bonusPoints) : base(goal, description, points)
    {
        this.BonusTimes = bonusTimes;
        this.BonusPoints = bonusPoints;
        this.EventsRecorded = 0;
        this.Type = "Checklist";
    }

    public override string DisplayGoal()
    {
        return base.DisplayGoal() + $" -- Currently completed: {EventsRecorded}/{BonusTimes}";
    }

    public int BonusTimes { get => _bonusTimes; set => _bonusTimes = value; }
    public int BonusPoints { get => _bonusPoints; set => _bonusPoints = value; }
    public int EventsRecorded { get => _eventsRecorded; set => _eventsRecorded = value; }
}