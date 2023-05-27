
class VehicleFactory
{

    public Vehicle CreateVehicle(string plate, string type, DateTime checkIn)
    {
        Vehicle nVehicle = null;
        if (type == "car")
        {
            nVehicle = new Car();
        }
        else if (type == "bike")
        {
            nVehicle = new Bike();
        }

        nVehicle.Plate = plate;
        nVehicle.Type = type;
        nVehicle.CheckIn = checkIn;

        return nVehicle;
    }
}