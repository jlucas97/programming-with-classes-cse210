
class BreathingActivity : Activity
{

    public BreathingActivity() : base("Welcome to the Breathing Activity", "This activity will help you relax by walking your" +
                      "through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public override void RunActivity(int timer)
    {
        Menu menu = new Menu();

        menu.GetReady();

        for (int i = 0; i < timer; i += 4)
        {
            Console.Write("Breathe in...");
            menu.Countdown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            menu.Countdown(5);
            Console.WriteLine("\n");
        }

        Console.WriteLine("Well Done!!!");
        menu.Spinner(2);
        DisplayFarewell(timer);
        Console.Clear();

    }

    public override string DisplayActivity()
    {
        return base.DisplayActivity();
    }

    public override string DisplayFarewell(int timer)
    {
        return $"You have completed another {timer} seconds of the Breathing Activity";
    }
}