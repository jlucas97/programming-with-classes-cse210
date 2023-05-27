using System;

class Program
{
    static void Main(string[] args)
    {

        //Added a class menu since the main method was getting very big and used Singleton with the menu instead

        Menu m = Menu.Instance;
        Menu.Instance.menu();
        string option = Console.ReadLine();
        Menu.Instance.actionMenu(option);

    }
}