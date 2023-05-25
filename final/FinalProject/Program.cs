using System;

class Program
{
    static void Main(string[] args)
    {
        void menu()
        {
            Console.WriteLine("Welcome to our parking lot!\n");
            Console.WriteLine("Press 1 to register the vehicle in the parking lot");
            Console.WriteLine("Press 2 to complete your payment");
            Console.WriteLine("Press any other key if you want to exit\n");
        }

        void actionMenu(int option = 0)
        {
            if (option == 1)
            {
                Console.WriteLine("Press 1 if this is a car\n" +
                                  "Press 2 if this is a motorcycle");
                string vType = Console.ReadLine();
                if (vType == "1")
                {
                    vType = "car";
                }
                else
                {
                    vType = "bike";
                }

                Console.WriteLine("What is your license plate: ");
                string licensePlate = Console.ReadLine();

                Console.WriteLine("What time is it?");
                string inputTime = Console.ReadLine();
                string[] time = inputTime.Split(":");
                int hour = Int32.Parse(time[0]);
                int minutes = Int32.Parse(time[1]);
                Console.WriteLine("Press 1 for AM\n"
                                 + "Press 2 for PM");
                int timeMeridian = Int32.Parse(Console.ReadLine());
                if (timeMeridian == 2)
                {
                    hour += 12;
                }
                DateTime checkIn = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minutes, 0);

                VehicleFactory vFactory = new VehicleFactory();
                //vFactory.CreateVehicle();

            }
        }

        menu();
        int option = int.Parse(Console.ReadLine());
        actionMenu(option);
    }


}