using System.Xml;

class Xml
{
    private string _filePath = Path.Combine(Directory.GetCurrentDirectory(), "Parking.xml");

    public void StoreVehicle(Vehicle[] vehicleArray)
    {
        XmlDocument xmlDoc = new XmlDocument();
        XmlElement xmlRoot = xmlDoc.CreateElement("Parking");

        XmlElement xmlVehicles = xmlDoc.CreateElement("Vehicles");

        foreach (var v in vehicleArray)
        {
            XmlElement xmlVehicle = xmlDoc.CreateElement("Vehicle");
            xmlVehicle.SetAttribute("Plate", v.Plate);
            xmlVehicle.SetAttribute("Type", v.Type);
            xmlVehicle.SetAttribute("Check_In", v.CheckIn.ToString());

            xmlVehicles.AppendChild(xmlVehicle);
        }

        xmlRoot.AppendChild(xmlVehicles);
        xmlDoc.AppendChild(xmlRoot);
        xmlDoc.Save(_filePath);
    }

    public List<Vehicle> LoadParking()
    {
        List<Vehicle> vList = new List<Vehicle>();

        if (System.IO.File.Exists(_filePath))
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_filePath);

            foreach (XmlNode item in xmlDoc.DocumentElement.SelectNodes("Vehicles/Vehicle"))
            {
                VehicleFactory vFactory = new VehicleFactory();
                string plate = item.Attributes["Plate"].Value;
                string type = item.Attributes["Type"].Value;
                DateTime checkIn = Convert.ToDateTime(item.Attributes["Check_In"].Value);

                var nVehicle = vFactory.CreateVehicle(plate, type, checkIn);
                vList.Add(nVehicle);
            }
        }
        return vList;
    }
}