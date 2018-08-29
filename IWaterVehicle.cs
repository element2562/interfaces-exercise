namespace vehicles
{
public interface IWaterVehicle
{
    double EngineVolume { get; set; }
    double MaxWaterSpeed { get; set; }
    int Doors { get; set; }
    string TransmissionType { get; set; }
    int PassengerCapacity { get; set; }
    void Start();
    void Stop();
}
}