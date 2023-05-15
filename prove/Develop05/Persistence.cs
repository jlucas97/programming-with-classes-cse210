
class Persistence
{
    private List<Goal> _goals = new List<Goal>();
    private Game _gamePoints;

    public Persistence()
    {
        this.GamePoints = new Game();
    }
    public void CreateGoal(int option)
    {
        Goal aGoal = null;
        string writtenGoal;
        string description;
        int points;

        if (option != 4)
        {
            Console.WriteLine("What is the name of your goal? ");
            writtenGoal = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            points = Int32.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("What is the name of your bad habit? ");
            writtenGoal = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            description = Console.ReadLine();
            Console.WriteLine("What is the amount of points you will lose with this habit?");
            points = Int32.Parse(Console.ReadLine());
        }


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
                case 4:
                    int habitTimes;
                    int lostPoints;

                    Console.WriteLine("How many times does this habit will subtract more points? ");
                    habitTimes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many points are loosing to do that habit that many times? ");
                    lostPoints = Convert.ToInt32(Console.ReadLine());

                    aGoal = new BadHabits(writtenGoal, description, points, habitTimes, lostPoints);
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

    public void SaveGoals(string fileName)
    {

        using (StreamWriter outputFile = new StreamWriter($"./{fileName}.txt"))
        {
            try
            {
                outputFile.WriteLine($"Points: {GamePoints.CumulatedPoints}");
                foreach (Goal i in Goals)
                {
                    if (i is Checklist)
                    {
                        var childItem = i as Checklist;
                        outputFile.WriteLine($"{i.Type}, {i.WrittenGoal}, {i.Description}, {i.Points}, {i.Checkbox}," +
                        $" {childItem.BonusTimes}, {childItem.BonusPoints}, {childItem.EventsRecorded}");
                    }
                    else
                    if (i is BadHabits)
                    {
                        var childItem = i as BadHabits;
                        outputFile.WriteLine($"{i.Type}, {i.WrittenGoal}, {i.Description}, {i.Points}, {i.Checkbox}," +
                        $" {childItem.BonusTimes}, {childItem.BonusPoints}, {childItem.EventsRecorded}");
                    }
                    else
                    {
                        outputFile.WriteLine($"{i.Type}, {i.WrittenGoal}, {i.Description}, {i.Points}, {i.Checkbox}");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }

    }

    public void LoadGoals(string fileName)
    {

        string[] lines = System.IO.File.ReadAllLines($"{fileName}.txt");
        bool firstElement = true;
        foreach (string line in lines)
        {
            string[] parts;
            if (firstElement)
            {
                parts = line.Split(":");
                int points = Convert.ToInt32(parts[1].Trim());
                GamePoints.CumulatedPoints = points;
                firstElement = false;
            }
            else
            {
                parts = line.Split(",");
                string gType = parts[0].Trim();
                string gName = parts[1].Trim();
                string gDescription = parts[2].Trim();
                int gPoints = Convert.ToInt32(parts[3].Trim());
                bool gChecked = Convert.ToBoolean(parts[4].Trim());

                if (gType == "Simple" || gType == "Eternal")
                {
                    if (gType == "Simple")
                    {
                        Simple gSimple = new Simple(gName, gDescription, gPoints);
                        gSimple.Checkbox = gChecked;
                        AddGoals(gSimple);
                    }
                    else
                    {
                        Eternal gEternal = new Eternal(gName, gDescription, gPoints);
                        AddGoals(gEternal);
                    }
                }
                else
                {
                    int gTimes = Convert.ToInt32(parts[5].Trim());
                    int gBonus = Convert.ToInt32(parts[6].Trim());
                    int gEvents = Convert.ToInt32(parts[7].Trim());
                    if (gType == "Checklist")
                    {
                        Checklist gChecklist = new Checklist(gName, gDescription, gPoints, gTimes, gBonus);
                        gChecklist.Checkbox = gChecked;
                        gChecklist.EventsRecorded = gEvents;
                        AddGoals(gChecklist);
                    }
                    else
                    {
                        BadHabits gBadHabits = new BadHabits(gName, gDescription, gPoints, gTimes, gBonus);
                        gBadHabits.Checkbox = gChecked;
                        gBadHabits.EventsRecorded = gEvents;
                        AddGoals(gBadHabits);
                    }
                }


            }
        }
    }

    public void RecordEvent()
    {
        int points = 0;
        bool lostPoints = false;
        Console.Clear();
        Console.WriteLine("The goals are: ");

        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i].WrittenGoal}");
        }

        Console.WriteLine("\nWhich goal did you accomplish? ");
        int index = Convert.ToInt32(Console.ReadLine());
        index--;

        for (int i = 0; i < Goals.Count; i++)
        {
            if (i == index)
            {
                Type goalType = Goals[i].GetType();

                if (goalType == typeof(Simple) || goalType == typeof(Eternal))
                {

                    points += Goals[i].Points;
                    if (goalType == typeof(Simple))
                    {
                        Goals[i].Checkbox = true;
                    }
                }
                else
                {
                    if (goalType == typeof(Checklist) && goalType != typeof(BadHabits))
                    {
                        var childItem = Goals[i] as Checklist;
                        points += Goals[i].Points;
                        childItem.EventsRecorded++;
                        if (childItem.BonusTimes == childItem.EventsRecorded)
                        {
                            points += childItem.BonusPoints;
                            childItem.Checkbox = true;
                        }
                    }
                    else
                    {
                        var childItem = Goals[i] as BadHabits;
                        points -= Goals[i].Points;
                        childItem.EventsRecorded++;
                        lostPoints = true;
                        if (childItem.BonusTimes == childItem.EventsRecorded)
                        {
                            points -= childItem.BonusPoints;
                            childItem.Checkbox = true;
                        }
                    }
                }
            }
        }

        GamePoints.RecordEvents(points);
        Console.WriteLine();
        if (lostPoints)
        {
            Console.WriteLine($"Unfortunately, you have lost {points * -1} points...");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        Console.WriteLine($"You now have {GamePoints.CumulatedPoints} points");
    }

    public List<Goal> Goals { get => _goals; set => _goals = value; }
    public Game GamePoints { get => _gamePoints; set => _gamePoints = value; }
}