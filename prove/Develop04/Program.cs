using System;

class Program
{
    static void Main(string[] args)
    {

        int option;
        Menu menuOptions = new Menu();
        bool exit = false;

        while (exit != true)
        {
            try
            {
                Console.WriteLine(menuOptions.DisplayMenu());
                option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                exit = menuOptions.ActionMenu(option);
            }
            catch (Exception ex)
            {
                Console.WriteLine("You should only use numbers in the menu");
                Console.Clear();
            }



        }

    }
}