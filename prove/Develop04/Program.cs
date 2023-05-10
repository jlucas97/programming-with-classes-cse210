using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        int option;
        int timer;
        string menuOptions = "Menu Options: \n" +
                             "  1. Start breathing activity\n" +
                             "  2. Start reflecting activity\n" +
                             "  3. Start listing activity\n" +
                             "  4. Quit\n" +
                             "Select a choice from the menu: ";

        while (exit != true)
        {
            Console.WriteLine(menuOptions);
            option = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (option)
            {
                case 1:
                    BreathingActivity bActivity = new BreathingActivity();
                    Console.WriteLine(bActivity.DisplayActivity());
                    timer = int.Parse(Console.ReadLine());
                    bActivity.MainBreathingActivity(timer);
                    exit = true;
                    break;
                case 2:
                    ReflectingActivity rActivity = new ReflectingActivity();
                    Console.WriteLine(rActivity.DisplayActivity());
                    timer = int.Parse(Console.ReadLine());
                    exit = true;
                    break;
                case 3:
                    ListingActivity lActivity = new ListingActivity();
                    Console.WriteLine(lActivity.DisplayActivity());
                    timer = int.Parse(Console.ReadLine());
                    exit = true;
                    break;
                case 4:
                    Console.WriteLine("See you soon!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("The menu only accepts numbers from 1-4");
                    break;
            }
        }

    }
}