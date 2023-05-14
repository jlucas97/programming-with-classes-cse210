
class Goal
{

    protected string _writtenGoal;
    protected string _description;
    protected int points;
    protected bool checkbox;

    public Goal(string goal, string description, int points)
    {
        this.WrittenGoal = goal;
        this.Description = description;
        this.Checkbox = false;
        this.Points = points;
    }

    public virtual string DisplayGoal()
    {
        return WrittenGoal + " " + $"({Description})";
    }

    public string WrittenGoal { get => _writtenGoal; set => _writtenGoal = value; }
    public string Description { get => _description; set => _description = value; }
    public int Points { get => points; set => points = value; }
    public bool Checkbox { get => checkbox; set => checkbox = value; }
}