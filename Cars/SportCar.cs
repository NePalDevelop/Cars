namespace Cars
{
    public class SportCar : Car
    {
        public SportCar(double consuptionFuel, double capacityTank, double currentFuelLevel, double velocity)
            : base(TypeOfTransport.Sport, consuptionFuel, capacityTank, currentFuelLevel, velocity)
        {

        }
    }
}
