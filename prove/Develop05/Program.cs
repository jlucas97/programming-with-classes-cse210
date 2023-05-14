using System;

class Program
{
    static void Main(string[] args)
    {
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