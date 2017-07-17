namespace P01_Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKm) : base(fuelQuantity, litersPerKm)
        {
            //this.FuelQuantity = fuelQuantity;
            //this.LitersPerKm = litersPerKm + 0.9;
        }

        public override void Drive(double distance)
        {
            if (distance > ((FuelQuantity / LitersPerKm) - distance * 0.9))
            {
                throw new ArgumentException("Car needs refueling");
            }
            Console.WriteLine($"Car travelled {distance} km");
            FuelQuantity = LitersPerKm * distance - distance * 0.9;
        }
    }
}
