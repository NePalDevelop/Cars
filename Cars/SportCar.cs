namespace Cars
{
    public class SportCar : Car
    {
        public SportCar(double consuptionFuel, double capacityTank, double currentFuelLevel, double velocity)
            : base(TransportsType.Sport, consuptionFuel, capacityTank, currentFuelLevel, velocity)
        {

        }
    }
}
