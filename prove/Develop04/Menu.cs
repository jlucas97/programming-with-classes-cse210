
public class Menu
{

    private List<string> animationSpinner = new List<string>();


    public void MainMenu()
    {

    }

    public string DisplayMenu()
    {
        return "Menu Options: \n" +
                             "  1. Start breathing activity\n" +
                             "  2. Start reflecting activity\n" +
                             "  3. Start listing activity\n" +
                             "  4. Quit\n" +
                             "Select a choice from the menu: ";
    }

    public bool ActionMenu(int option)
    {
        bool exit = false;
        int timer;

        switch (option)
        {
            case 1:
                BreathingActivity bActivity = new BreathingActivity();
                Console.WriteLine(bActivity.DisplayActivity());
                timer = int.Parse(Console.ReadLine());
                Console.Clear();
                bActivity.RunActivity(timer);
                break;
            case 2:
                ReflectingActivity rActivity = new ReflectingActivity();
                Console.WriteLine(rActivity.DisplayActivity());
                timer = int.Parse(Console.ReadLine());
                Console.Clear();
                rActivity.RunActivity(timer);
                break;
            case 3:
                ListingActivity lActivity = new ListingActivity();
                Console.WriteLine(lActivity.DisplayActivity());
                timer = int.Parse(Console.ReadLine());
                Console.Clear();
                lActivity.RunActivity(timer);
                break;
            case 4:
                Console.WriteLine("See you soon!");
                exit = true;
                break;
            default:
                Console.WriteLine("The menu only accepts numbers from 1-4");
                break;
        }

        return exit;
    }

    public void GetReady()
    {
        string readyMessage = "Get ready";
        int dots = 1;
        int messageLength;

        for (int i = 6; i >= 0; i--)
        {
            Console.Write($"{readyMessage}");
            Thread.Sleep(1000);
            messageLength = readyMessage.Length;
            readyMessage = "Get ready";
            while (messageLength > 0 && i != 0)
            {
                Console.Write("\b \b");
                messageLength--;
            }
            for (int j = 1; j <= 3; j++)
            {
                readyMessage += ".";
                if (j == 3)
                {
                    dots = 1;
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
    }

    public void Countdown(int seconds)
    {
        for (int j = seconds; j > 0; j--)
        {
            Console.Write($"{j}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void Spinner(int times)
    {
        animationSpinner.Add("|");
        animationSpinner.Add("/");
        animationSpinner.Add("-");
        animationSpinner.Add("\\");

        for (int i = 0; i < times; i++)
        {
            foreach (string aChar in animationSpinner)
            {
                Console.Write(aChar);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }

        }
    }
}