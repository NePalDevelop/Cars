using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(0, 0.1, 50, 30, 90);
            Car car = new PassengerCar(0.1, 50, 30, 90, 2);

            Console.WriteLine(@"Auto - {0}, Remaining Path = {1}, Max Path = {2}, Travel Time per 200 km = {3}",
                car1.TypeCar, car1.CurrentRemainingPath(), car1.MaxPath(), car1.TravelTime(200));
            Console.WriteLine(@"Auto - {0}, Remaining Path = {1}, Max Path = {2}, Travel Time per 200 km = {3}", 
                car.TypeCar, car.CurrentRemainingPath(), car.MaxPath(), car.TravelTime(200));
        }
    }
}
