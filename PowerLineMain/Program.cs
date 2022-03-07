using PowerLine;
using System;

namespace PowerLineMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PassengerCar passengerCar = new PassengerCar();
            ICarCreator<PassengerCar> passengerCarCreator = new CarCreator<PassengerCar>(passengerCar);

            passengerCarCreator.GetCar.AvgFuelCost = 20;
            passengerCarCreator.GetCar.CurrentFuelVolume = 100;
            passengerCarCreator.GetCar.Speed = 5;
            Console.WriteLine(passengerCarCreator.GetCar.CalculateTimeToDestination(305));
            Console.ReadLine();
        }
    }
}
