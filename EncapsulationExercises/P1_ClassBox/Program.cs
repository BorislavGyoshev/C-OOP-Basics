using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_ClassBox
{
    class Program
    {
        static void Main()
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(3);
            try
            {
                Box box = new Box(l, w, h);
                Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.Volume():f2}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
