using System;
using System.Collections.Generic;
namespace vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Corvette> cars = new List<Corvette>();
            List<Jetski> boats = new List<Jetski>();
            List<Jettyboi> planes = new List<Jettyboi>();
            Corvette carOne = new Corvette();
            Corvette carTwo = new Corvette();
            Jetski boatOne = new Jetski();
            Jetski boatTwo = new Jetski();
            Jettyboi planeOne = new Jettyboi();
            Jettyboi planeTwo = new Jettyboi();
            cars.Add(carOne);
            cars.Add(carTwo);
            boats.Add(boatOne);
            boats.Add(boatTwo);
            planes.Add(planeOne);
            planes.Add(planeTwo);
            foreach (Corvette item in cars)
            {
                item.Start();
            }
            foreach (Jetski item in boats)
            {
                item.Start();
            }
            foreach (Jettyboi item in planes)
            {
                item.Fly();
            }
        }
    }
}
