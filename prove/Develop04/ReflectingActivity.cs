

class ReflectingActivity : Activity
{
    private List<string> _ponderingPhrases = new List<string>();
    private List<string> _questionList = new List<string>();

    public ReflectingActivity() : base("Welcome to the Reflecting Activity", "This activity will help you " +
     "reflect on times in your life when you have shown strength and resilience. " +
     "This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public void PonderingPhrasesList()
    {
        _ponderingPhrases.Add("Reflect on a time when you stood up for your beliefs.");
        _ponderingPhrases.Add("Remember a time when you overcame a significant challenge.");
        _ponderingPhrases.Add("Recollect a moment when you made a positive impact on someone's life.");
        _ponderingPhrases.Add("Consider a situation where you sacrificed your own needs for someone else's.");
        _ponderingPhrases.Add("Ponder a memory where you displayed immense courage and bravery.");
    }

    public string PonderingPhrases()
    {
        string phrase = "";
        if (_ponderingPhrases.Count < 1)
        {
            phrase = "There are no more pondering phrases, restart the program";
        }
        else
        {
            Random rd = new Random();
            int index = rd.Next(0, _ponderingPhrases.Count);

            phrase = _ponderingPhrases[index];
            _ponderingPhrases.RemoveAt(index);
        }
        return phrase;
    }

    public void QuestionsList()
    {
        _questionList.Add("Why was this experience meaningful to you?");
        _questionList.Add("Have you ever done anything like this before?");
        _questionList.Add("How did you get started?");
        _questionList.Add("How did you feel when it was complete?");
        _questionList.Add("What made this time different than other times when you were not as successful?");
        _questionList.Add("What is your favorite thing about this experience?");
        _questionList.Add("What could you learn from this experience that applies to other situations?");
        _questionList.Add("What did you learn about yourself through this experience?");
        _questionList.Add("How can you keep this experience in mind in the future?");
    }

    public string Questions()
    {
        string phrase = "";
        if (_questionList.Count < 1)
        {
            phrase = "There are no more pondering phrases, restart the program";
        }
        else
        {
            Random rd = new Random();
            int index = rd.Next(0, _questionList.Count);

            phrase = _questionList[index];
            _questionList.RemoveAt(index);
        }
        return phrase;
    }


    public override void RunActivity(int timer)
    {
        Menu menu = new Menu();
        menu.GetReady();
        string userInput;

        Console.WriteLine("Consider the following prompt:");
        PonderingPhrasesList();
        Console.WriteLine($"--- {PonderingPhrases()}---");
        Console.WriteLine("When you have something in mind, press enter to continue");
        userInput = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        menu.Countdown(5);

        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(timer);
        QuestionsList();
        string aQuestion;
        bool hitEnter = false;


        while (DateTime.Now < endTime)
        {

            Console.Write(aQuestion = Questions() + "\n");
            hitEnter = false;

            while (!hitEnter && DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    hitEnter = keyInfo.Key == ConsoleKey.Enter;
                    break;
                }
                else
                {
                    menu.Spinner(1);
                }

            }
        }

        Console.WriteLine("\nWell done! \n");
        Console.WriteLine(DisplayFarewell(timer));
        menu.Countdown(6);
        Console.Clear();
    }



    public override string DisplayActivity()
    {
        return base.DisplayActivity();
    }



    public override string DisplayFarewell(int timer)
    {
        return $"You have completed another {timer} seconds of the Reflecting Activity";
    }
}