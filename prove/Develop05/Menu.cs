
class Menu
{
    private Persistence _persistence;

    public Menu()
    {
        APersistence = new Persistence();
    }

    public string DisplayMenu()
    {
        return "Menu Options: \n" +
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
                APersistence.DisplayAllGoals();
                Console.WriteLine("\n");
                break;
            case 6:
                exit = true;
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
        "Which type of goal would you like to create? \n";
    }

    public void ActionGoalsMenu(int option)
    {
        APersistence.CreateGoal(option);
    }

    public Persistence APersistence { get => _persistence; set => _persistence = value; }
}