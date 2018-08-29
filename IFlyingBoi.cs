namespace vehicles
{
public interface IFlyingBoi
{
    double EngineVolume { get; set; }
    string TransmissionType { get; set; }
    double MaxAirSpeed { get; set; }
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    bool Winged { get; set; }
    void Start();
    void Stop();
    void Fly();
}
}