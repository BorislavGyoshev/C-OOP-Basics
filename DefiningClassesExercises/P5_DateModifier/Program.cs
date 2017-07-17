using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_DateModifier
{
    class Program
    {
        static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            Console.WriteLine(DateModifier.GetDaysBetweenDates(firstDate, secondDate));
        }
    }
}
