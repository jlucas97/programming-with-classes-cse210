
class ListingActivity : Activity
{
    List<string> _messages = new List<string>();

    public ListingActivity() : base("Welcome to the Listing Activity", "This activity will help you reflect on " +
     "the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public string InspiringMessage()
    {
        string message = "";
        _messages.Add("Who are people that you appreciate?");
        _messages.Add("What are personal strengths of yours?");
        _messages.Add("Who are people that you have helped this week?");
        _messages.Add("When have you felt the Holy Ghost this month?");
        _messages.Add("Who are some of your personal heroes?");

        Random rd = new Random();
        int index = rd.Next(0, _messages.Count);
        message = _messages[index];

        return message;
    }


    public override void RunActivity(int timer)
    {
        Menu menu = new Menu();
        menu.GetReady();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {InspiringMessage()} ---");
        Console.Write("You may begin in: ");
        menu.Countdown(5);
        Console.WriteLine("\n");

        string userPrompts;
        int counter = 0;
        DateTime endTime = DateTime.Now.AddSeconds(timer);

        while (DateTime.Now < endTime)
        {
            userPrompts = Console.ReadLine();
            counter++;
        }

        Console.WriteLine($"\nYou have listed {counter} items");
        Console.WriteLine("\nWell done!!\n");

        Console.WriteLine(DisplayFarewell(timer));

        Console.WriteLine("Loading menu...");
        menu.Spinner(3);

    }

    public override string DisplayActivity()
    {
        return base.DisplayActivity();
    }

    public override string DisplayFarewell(int timer)
    {
        return $"You have completed another {timer} seconds of the Listing Activity.";
    }
}
