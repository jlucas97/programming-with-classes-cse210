
class Bike : Vehicle
{
    public Bike() : base()
    {
        PricePerHour = 1.5;
    }

    public override double CalculateTotal()
    {
        TimeSpan parkingDuration = CheckOut - CheckIn;
        int timeInParking = (int)parkingDuration.TotalHours;
        double total;

        if (timeInParking < 4)
        {
            PricePerHour = 0.75;
            total = PricePerHour * timeInParking;
        }
        else
        {
            total = PricePerHour * timeInParking;
        }

        if (total == 0)
            total = 0.75;

        return total;
    }
}