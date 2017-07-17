using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_DrawingTool
{
    class Program
    {
        public static void Main()
        {
            var shape = Console.ReadLine();
            var width = double.Parse(Console.ReadLine());
            double height;

            if (shape == "Square")
            {
                height = width;
            }
            else
            {
                height = double.Parse(Console.ReadLine());
            }

            var figure = new CorDraw(width, height);
            Console.WriteLine(figure.Draw());
        }
    }
}
