
class Parking
{
    private List<Vehicle> _list = new List<Vehicle>();
    private const int Capacity = 4;
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

    }

    public static void RemoveCar(string plate)
    {

    }

    public static Vehicle FindPlate(string plate)
    {
        return null;
    }

    public static void GenerateReceipt(Vehicle vh)
    {

    }


    public List<Vehicle> List { get => _list; set => _list = value; }
}