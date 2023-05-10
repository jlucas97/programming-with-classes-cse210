
class BreathingActivity : Activity
{

    public BreathingActivity() : base("Welcome to the Breathing Activity", "This activity will help you relax by walking your" +
                      "through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void MainBreathingActivity(int timer)
    {
        string readyMessage = "Get ready.";
        int dots = 1;
        int messageLength;

        for (int i = 5; i >= 0; i--)
        {
            Console.Write($"{readyMessage}");
            Thread.Sleep(1000);
            messageLength = readyMessage.Length;
            readyMessage = "Get ready";
            while (messageLength > 0)
            {
                Console.Write("\b");
                messageLength--;
            }
            for (int j = 1; j < 3; j++)
            {
                readyMessage += ".";
                if (j == 3)
                {
                    dots = 1;
                    readyMessage = "Get ready.";
                    break;
                }
                if (j == dots)
                {
                    dots++;
                    break;
                }

            }
        }
        Console.WriteLine("\n\n");

        for (int i = 0; i <= timer; i += 5)
        {
            Console.Write("Breathe in...");
            for (int j = 5; j > 0; j--)
            {
                Console.Write($"{j}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\n");
        }
    }

    public override string DisplayActivity()
    {
        return base.DisplayActivity();
    }
}