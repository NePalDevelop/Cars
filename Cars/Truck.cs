﻿using System;

namespace Cars
{
    public class Truck : Car
    {
        private const double CargoCapacity = 3000;
        private const double ReducingPathforBlocks = 0.04;
        private const double BlockWeight = 200;
        private double _currentWeight;

        public double CurrentWeight
        {
            get => _currentWeight;
            set
            {
                if (value > CargoCapacity || value < 0)
                {
                    throw new ArgumentOutOfRangeException("Unacceptable number of passengers");
                }
                else
                {
                    _currentWeight = value;
                }
            }
        }

        public Truck(double consuptionFuel, double capacityTank, double currentFuelLevel, double velocity,
            double currentWeight)
            : base (TransportsType.Truck, consuptionFuel, capacityTank, currentFuelLevel, velocity)
        {
            _currentWeight = currentWeight;
        }

        public override double RemainingPath(double fuelLevel)
        {
            return base.RemainingPath(fuelLevel) * (1 - (CurrentWeight / BlockWeight) * ReducingPathforBlocks);
        }
    }
}
