using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_RawData
{
    public class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }

        public int Power
        {
            get { return this.power; }
        }
    }
}
