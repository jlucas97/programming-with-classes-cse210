
class Bike : Vehicle
{
    public Bike(string plate, string type, DateTime checkIn) : base(plate, type, checkIn)
    {
        PricePerHour = 1.5;
    }

    public override double CalculateTotal()
    {
        int timeInParking = Convert.ToInt32(CheckOut) - Convert.ToInt32(CheckIn);

        if (timeInParking < 3)
        {
            PricePerHour = 0.75;
            return PricePerHour * timeInParking;
        }
        else
        {
            return PricePerHour * timeInParking;
        }
    }
}