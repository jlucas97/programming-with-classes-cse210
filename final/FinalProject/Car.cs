
class Car : Vehicle
{
    public Car(string plate, string type, DateTime checkIn) : base(plate, type, checkIn)
    {
        PricePerHour = 3;
    }

    public override double CalculateTotal()
    {
        int timeInParking = Convert.ToInt32(CheckOut) - Convert.ToInt32(CheckIn);

        if (timeInParking < 3)
        {
            PricePerHour = 2;
            return PricePerHour * timeInParking;
        }
        else
        {
            return PricePerHour * timeInParking;
        }
    }


}