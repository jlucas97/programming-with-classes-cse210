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
            Console.WriteLine(menuOptions.DisplayMenu());
            option = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            exit = menuOptions.ActionMenu(option);

        }

    }
}