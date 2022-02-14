using System;
using System.Collections.Generic;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new();

            cars.Add(new SportCar(0.1, 50, 30, 150));
            cars.Add(new PassengerCar(0.1, 50, 30, 90, 2));
            cars.Add(new Truck(0.2, 200, 120, 90, 1500));

            foreach (var car in cars) 
            Console.WriteLine(@"Auto - {0}, Remaining Path = {1}, Max Path = {2}, Travel Time per 200 km = {3}",
                car.TypeCar, car.CurrentRemainingPath(), car.MaxPath(), car.TravelTime(200));
        }
    }
}
