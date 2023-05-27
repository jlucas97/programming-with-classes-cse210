
class Menu
{
    private static Menu _instance;

    private Menu()
    {

    }

    public static Menu Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Menu();
            }
            return _instance;
        }
    }


    public void menu()
    {
        Console.WriteLine("Welcome to our parking lot!\n");
        Console.WriteLine("Press 1 to register the vehicle in the parking lot");
        Console.WriteLine("Press 2 to complete your payment");
        Console.WriteLine("Press any other key if you want to exit\n");
    }

    public void actionMenu(string option)
    {
        Xml xml = new Xml();
        Parking p = Parking.Instance;
        Vehicle[] parkingData;
        Parking.VList = xml.LoadParking();
        string licensePlate;
        string vType;
        bool escapeBool = true;

        if (!(Parking.VList.Count < Parking.Capacity))
        {
            Parking.IsFull = true;
        }

        if (option == "1")
        {

            if (Parking.IsFull == true)
            {
                Console.Clear();
                Console.WriteLine("We're sorry! The parking lot is full, please come back later");
                return;
            }
            do
            {
                escapeBool = true;
                Console.WriteLine("Press 1 if this is a car\n" +
                              "Press 2 if this is a motorcycle");
                vType = Console.ReadLine();
                if (vType == "1")
                {
                    vType = "car";
                }
                else if (vType == "2")
                {
                    vType = "bike";
                }
                else
                {
                    Console.WriteLine("Please type either 1 or 2 ");
                    escapeBool = false;
                }

            } while (!escapeBool);

            Console.WriteLine("What is your license plate: ");
            licensePlate = Console.ReadLine().ToUpper();

            Console.WriteLine("What time is it?");
            string inputTime = Console.ReadLine();
            string[] time = inputTime.Split(":");
            int hour = Int32.Parse(time[0]);
            int minutes = Int32.Parse(time[1]);

            do
            {
                escapeBool = true;
                try
                {
                    Console.WriteLine("Press 1 for AM\n"
                             + "Press 2 for PM");
                    int timeMeridian = Int32.Parse(Console.ReadLine());
                    if (timeMeridian == 2)
                    {
                        if (hour < 12)
                        {
                            hour += 12;
                        }
                    }

                    if (timeMeridian != 1 && timeMeridian != 2)
                    {
                        Console.WriteLine("Please type either 1 or 2 ");
                        escapeBool = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Please type either 1 or 2 ");
                    escapeBool = false;
                }

            } while (!escapeBool);

            DateTime checkIn = DateTime.Today;
            checkIn = checkIn.AddHours(hour);
            checkIn = checkIn.AddMinutes(minutes);
            //(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minutes, 0);

            VehicleFactory vFactory = new VehicleFactory();
            Parking.AddCar(vFactory.CreateVehicle(licensePlate, vType, checkIn));
            parkingData = Parking.VList.ToArray();
            xml.StoreVehicle(parkingData);

        }
        else if (option == "2")
        {
            Console.WriteLine("Please enter your plate, so we can calculate the total amount:");
            licensePlate = Console.ReadLine().ToUpper();
            Vehicle vh = Parking.FindPlate(licensePlate);

            if (vh != null)
            {
                Console.WriteLine("What time is it?");
                string inputTime = Console.ReadLine();
                string[] time = inputTime.Split(":");
                int hour = Int32.Parse(time[0]);
                int minutes = Int32.Parse(time[1]);
                do
                {
                    escapeBool = true;
                    try
                    {
                        Console.WriteLine("Press 1 for AM\n"
                                 + "Press 2 for PM");
                        int timeMeridian = Int32.Parse(Console.ReadLine());
                        if (timeMeridian == 2)
                        {
                            if (hour < 12)
                            {
                                hour += 12;
                            }
                        }

                        if (timeMeridian != 1 && timeMeridian != 2)
                        {
                            Console.WriteLine("Please type either 1 or 2 ");
                            escapeBool = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please type either 1 or 2 ");
                        escapeBool = false;
                    }

                } while (!escapeBool);
                DateTime checkOut = DateTime.Today;
                checkOut = checkOut.AddHours(hour);
                checkOut = checkOut.AddMinutes(minutes);
                vh.CheckOut = checkOut;

                Parking.GenerateReceipt(vh);
                Console.ReadLine();
                Parking.RemoveCar(vh.Plate);
                xml.StoreVehicle(Parking.VList.ToArray());
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, it looks like the license plate is not correct, please try again");
                Console.WriteLine();
                Console.WriteLine("Type quit to finish or hit any key to continue");
                string quittingOption = Console.ReadLine().ToLower();
                if (quittingOption == "quit")
                    return;

                Console.Clear();
                actionMenu("2");
            }

        }
        else
        {
            Console.WriteLine("See you soon!");
        }
    }
}

