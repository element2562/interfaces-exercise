using System;
namespace vehicles
{
    public class Jetski
    {
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }
    public int Doors { get; set; }
    public string TransmissionType { get; set; }
    public int PassengerCapacity { get; set; }
    public void Start(){
        Console.WriteLine("Engine started");
    }
    public void Stop(){
        Console.WriteLine("Engine stopped");
    }
    }
}