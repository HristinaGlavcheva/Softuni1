﻿namespace _01._Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double AirConditionerFuelConsumptionIncreasment = 0.9;
        
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption 
            => base.FuelConsumption + AirConditionerFuelConsumptionIncreasment;
    }
}
