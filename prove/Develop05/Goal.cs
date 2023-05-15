
class Goal
{

    protected string _writtenGoal;
    protected string _description;
    protected int _points;
    protected bool _checkbox;
    protected string _type;

    public Goal(string goal, string description, int points)
    {
        this.WrittenGoal = goal;
        this.Description = description;
        this.Checkbox = false;
        this.Points = points;
        this.Type = "";
    }

    public virtual string DisplayGoal()
    {
        return WrittenGoal + " " + $"({Description})";
    }

    public string WrittenGoal { get => _writtenGoal; set => _writtenGoal = value; }
    public string Description { get => _description; set => _description = value; }
    public int Points { get => _points; set => _points = value; }
    public bool Checkbox { get => _checkbox; set => _checkbox = value; }
    public string Type { get => _type; set => _type = value; }
}