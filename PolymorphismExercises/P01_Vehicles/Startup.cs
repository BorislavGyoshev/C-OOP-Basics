using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P01_Vehicles
{
    class Startup
    {
        static void Main()
        {
            string[] carInfo = Console.ReadLine().Split();
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            string[] truckInfo = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string comand = Console.ReadLine();
                string[] amound = comand.Split();
                double distance = 0;
                double liters = 0;
                try
                {
                    if (Regex.IsMatch(comand, "Drive Car"))
                    {
                        distance = double.Parse(amound[2]);
                        car.Drive(distance);
                        Console.WriteLine(car.FuelQuantity);
                    }
                    else if (Regex.IsMatch(comand, "Drive Truck"))
                    {
                        distance = double.Parse(amound[2]);
                        truck.Drive(distance);
                    }
                    else if (Regex.IsMatch(comand, "Refuel Car"))
                    {
                        liters = double.Parse(amound[2]);
                        car.Refuel(liters);
                    }
                    else if (Regex.IsMatch(comand, "Refuel Truck"))
                    {
                        liters = double.Parse(amound[2]);
                        truck.Refuel(liters);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
