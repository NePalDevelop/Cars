namespace Cars
{
    public abstract class Car
    {
        public TypeOfTransport TypeCar { get; set; }
        public double ConsumptionFuelAverage { get; set; }
        public double CapacityFuelTank { get; set; }
        public double CurrentFuelLevel { get; set; }
        public double Velocity { get; set; }

        public Car(TypeOfTransport typeCar, double consuptionFuel, double capacityTank, double currentFuelLevel, double velocity)
        {
            TypeCar = typeCar;
            ConsumptionFuelAverage = consuptionFuel;
            CapacityFuelTank = capacityTank;
            CurrentFuelLevel = currentFuelLevel;
            Velocity = velocity;
        }

        public virtual double RemainingPath (double fuelLevel)
        {
            return fuelLevel / ConsumptionFuelAverage;
        }

        public double CurrentRemainingPath()
        {
            return RemainingPath(CurrentFuelLevel);
        }

        public double MaxPath()
        {
            return RemainingPath(CapacityFuelTank);
        }

        public double TravelTime(double pathLenth)
        {
            return pathLenth / Velocity;
        }
    }
}
