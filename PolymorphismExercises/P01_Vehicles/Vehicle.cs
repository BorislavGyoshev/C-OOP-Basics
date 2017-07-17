namespace P01_Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double litersPerKm;

        public Vehicle(double fuelQuantity, double litersPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.LitersPerKm = litersPerKm;
        }

        private virtual double LitersPerKm
        {
            get { return litersPerKm; }
            set { litersPerKm = value; }
        }        
        private virtual double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public abstract void Drive(double distance);
        public virtual void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }
    }
}
