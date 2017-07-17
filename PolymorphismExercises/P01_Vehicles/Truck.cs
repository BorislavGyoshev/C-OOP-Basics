namespace P01_Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKm) : base(fuelQuantity, litersPerKm)
        {
            //this.FuelQuantity = fuelQuantity;
            //this.LitersPerKm = litersPerKm * 1.6;
        }

        public override void Drive(double distance)
        {
            if (distance > FuelQuantity / LitersPerKm)
            {
                throw new ArgumentException("Truck needs refueling");
            }
            Console.WriteLine($"Truck travelled {distance} km");
            FuelQuantity -= LitersPerKm * distance;
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters * 0.95);
        }
    }
}
