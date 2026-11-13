public class Vehicle
{
    public string PlateNumber { get; set; }
    public string VehicleType { get; set; }

    public Vehicle(string plateNumber, string vehicleType)
    {
        PlateNumber = plateNumber;
        VehicleType = vehicleType;
    }
}