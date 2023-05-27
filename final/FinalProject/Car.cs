
class Car : Vehicle
{
    public Car() : base()
    {
        PricePerHour = 3;
    }

    public override double CalculateTotal()
    {
        TimeSpan parkingDuration = CheckOut - CheckIn;
        int timeInParking = (int)parkingDuration.TotalHours;
        double total;

        if (timeInParking < 3)
        {
            PricePerHour = 2;
            total = PricePerHour * timeInParking;
        }
        else
        {
            total = PricePerHour * timeInParking;
        }

        if (total == 0)
            total = 2;

        return total;
    }


}