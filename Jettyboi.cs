using System;
namespace vehicles
{
    public class Jettyboi
    {
    double EngineVolume { get; set; }
    string TransmissionType { get; set; }
    double MaxAirSpeed { get; set; }
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    bool Winged { get; set; }
    public void Start(){
        Console.WriteLine("Engine started");
    }
    public void Stop(){
        Console.WriteLine("Engine stopped");
    }
    public void Fly(){
        Console.WriteLine("You're flying fam");
    }
    }
}