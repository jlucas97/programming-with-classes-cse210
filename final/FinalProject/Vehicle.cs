
class Vehicle
{
    protected string _plate;
    protected string _type;
    protected DateTime _checkIn;
    protected DateTime _checkOut;
    protected double _pricePerHour;

    public Vehicle(string plate, string type, DateTime checkIn)
    {
        Plate = plate;
        Type = type;
        CheckIn = checkIn;
    }

    public virtual double CalculateTotal()
    {
        return 0;
    }

    public string Plate { get => _plate; set => _plate = value; }
    public string Type { get => _type; set => _type = value; }
    public DateTime CheckIn { get => _checkIn; set => _checkIn = value; }
    public DateTime CheckOut { get => _checkOut; set => _checkOut = value; }
    public double PricePerHour { get => _pricePerHour; set => _pricePerHour = value; }
}