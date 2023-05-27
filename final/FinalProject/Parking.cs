
class Parking
{
    private static List<Vehicle> _vList = new List<Vehicle>();
    public const int Capacity = 4;
    private static bool _isFull;
    private static Parking _instance;

    private Parking()
    {

    }

    public static Parking Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Parking();
            }
            return _instance;
        }
    }

    public static void AddCar(Vehicle vh)
    {
        if (VList.Count < Capacity)
        {
            VList.Add(vh);
            Console.Clear();
            Console.WriteLine("Thank you for choosing us! We will take care of your vehicle");
        }
    }

    public static void RemoveCar(string plate)
    {
        Vehicle vh = FindPlate(plate);
        if (vh != null)
        {
            VList.Remove(vh);
            Console.Clear();
            Console.WriteLine("Thanks for choosing us! Come back later!");
        }
    }

    public static Vehicle FindPlate(string plate)
    {
        return VList.Find(v => v.Plate == plate);
    }

    public static void GenerateReceipt(Vehicle vh)
    {
        string plate = vh.Plate;
        DateTime today = DateTime.Today;
        double totalAmount = vh.CalculateTotal();
        DateTime checkIn = vh.CheckIn;
        DateTime checkOut = vh.CheckOut;
        Receipt newReceipt = new Receipt(plate, today, totalAmount, checkIn, checkOut);
        Console.Clear();
        Console.WriteLine(newReceipt.ToString());
    }


    public static List<Vehicle> VList { get => _vList; set => _vList = value; }
    public static bool IsFull { get => _isFull; set => _isFull = value; }
}