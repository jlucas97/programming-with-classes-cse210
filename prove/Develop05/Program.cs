using System;

class Program
{
    static void Main(string[] args)
    {
        // I added the BadHabits class which is a goal that subtract points when made
        // in order to exceed the core requirements.

        Menu menu = new Menu();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine(menu.DisplayMenu());
            try
            {
                int optionMenu = Convert.ToInt32(Console.ReadLine());
                exit = menu.ActionMenu(optionMenu);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


    }
}