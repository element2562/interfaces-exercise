namespace vehicles
{
public interface ILandVehicle
{
    double EngineVolume { get; set; }
    double MaxLandSpeed { get; set; }
    int Wheels { get; set; }
    int Doors { get; set; }
    string TransmissionType { get; set; }
    int PassengerCapacity { get; set; }
    void Start();
    void Stop();
}
}