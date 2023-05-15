
class Menu
{
    private Persistence _persistence;

    public Menu()
    {
        APersistence = new Persistence();

    }

    public string DisplayMenu()
    {
        return $"\nYou have {APersistence.GamePoints.CumulatedPoints} points\n\n" +
        "Menu Options: \n" +
        "  1. Create New Goal \n" +
        "  2. List Goals \n" +
        "  3. Save Goals \n" +
        "  4. Load Goals \n" +
        "  5. Record Event \n" +
        "  6. Quit";
    }

    public bool ActionMenu(int option)
    {
        bool exit = false;
        int newOption;
        switch (option)
        {
            case 1:
                Console.WriteLine(GoalsMenu());
                newOption = Int32.Parse(Console.ReadLine());
                ActionGoalsMenu(newOption);
                break;
            case 2:
                Console.Clear();
                APersistence.DisplayAllGoals();
                Console.WriteLine("\nPlease hit enter once you're done");
                Console.ReadLine();
                Console.WriteLine("\n");
                break;
            case 3:
                Console.Clear();
                string fileName;
                Console.WriteLine("What is the name of the file you're saving? Please don't add the extension");
                fileName = Console.ReadLine();
                APersistence.SaveGoals(fileName);
                Console.WriteLine("Goals saved succesfully!");
                break;
            case 4:
                Console.Clear();
                string filename;
                Console.WriteLine("What is the name of the file you're loading? Please don't add the extension");
                filename = Console.ReadLine();
                APersistence.LoadGoals(filename);
                Console.WriteLine("Goals loaded successfully\n");
                break;
            case 5:
                APersistence.RecordEvent();
                Console.WriteLine();
                break;
            case 6:
                exit = true;
                Console.Clear();
                Console.WriteLine("See you soon!");
                break;
            default:
                Console.WriteLine("The menu only accepts numbers from 1-6");
                break;
        }

        return exit;
    }

    public string GoalsMenu()
    {
        return "\nThe types of goals are: \n" +
        "  1. Simple Goal\n" +
        "  2. Eternal Goal\n" +
        "  3. Checklist Goal\n" +
        "  4. Bad Habit\n" +
        "Which type of goal would you like to create? \n";
    }

    public void ActionGoalsMenu(int option)
    {
        APersistence.CreateGoal(option);
    }

    public Persistence APersistence { get => _persistence; set => _persistence = value; }
}