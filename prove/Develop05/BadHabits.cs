
class BadHabits : Checklist
{
    public BadHabits(string goal, string description, int points, int bonusTimes, int bonusPoints) : base(goal, description, points, bonusTimes, bonusPoints)
    {
        this.Type = "BadHabits";
    }


}