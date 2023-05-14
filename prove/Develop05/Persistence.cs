
class Persistence
{
    private List<Goal> _goals = new List<Goal>();
    public Goal CreateGoal(int option)
    {
        Goal aGoal = null;
        string writtenGoal;
        string description;
        int points;

        Console.WriteLine("What is the name of your goal? ");
        writtenGoal = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        points = Int32.Parse(Console.ReadLine());

        try
        {
            switch (option)
            {
                case 1:
                    aGoal = new Simple(writtenGoal, description, points);
                    AddGoals(aGoal);
                    break;
                case 2:
                    aGoal = new Eternal(writtenGoal, description, points);
                    AddGoals(aGoal);
                    break;
                case 3:
                    int bonusTimes;
                    int bonusPoints;

                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    bonusTimes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                    bonusPoints = Convert.ToInt32(Console.ReadLine());

                    aGoal = new Checklist(writtenGoal, description, points, bonusTimes, bonusPoints);
                    AddGoals(aGoal);
                    break;
                default:
                    Console.WriteLine("The menu only accepts numbers from 1-3");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("This menu only accepts numbers " + ex);
        }

        Console.Clear();
        return aGoal;
    }

    public void AddGoals(Goal aGoal)
    {
        Goals.Add(aGoal);
    }

    public void DisplayAllGoals()
    {
        int counter = 1;
        Console.Clear();
        Console.WriteLine("The goals are:");
        foreach (Goal goal in Goals)
        {
            if (goal.Checkbox == false)
            {
                Console.WriteLine($"{counter}. [] " + goal.DisplayGoal());
            }
            else
            {
                Console.WriteLine($"{counter}. [X] " + goal.DisplayGoal());
            }
            counter++;
        }
    }

    public List<Goal> Goals { get => _goals; set => _goals = value; }

}