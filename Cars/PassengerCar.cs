using System;

namespace Cars
{
    public class PassengerCar : Car
    {
        public const int PassengersMax = 4;
        public const double ReducingPathforeachPassenger = 0.06;
        private int _passengersCurrent;

        public int PassengersCurrent {
            get => _passengersCurrent;
            protected set 
            {
                if (value > PassengersMax || value < 0)
                {
                    throw new ArgumentOutOfRangeException("Unacceptable number of passengers");
                }
                else
                {
                    _passengersCurrent = value;
                }
            }
        }

        public PassengerCar(double consuptionFuel, double capacityTank, double currentFuelLevel, double velocity,
            int passengersCurrent)
            : base(TypeOfTransport.Passenger, consuptionFuel, capacityTank, currentFuelLevel, velocity)
        {
            PassengersCurrent = passengersCurrent;
        }

        public override double RemainingPath(double fuelLevel)
        {
            return base.RemainingPath(fuelLevel) * (1 - PassengersCurrent * ReducingPathforeachPassenger);
        }
    }
}
