using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_ClassBox
{
    class Box
    {
        private double l;
        private double w;
        private double h;

        public Box(double l, double w, double h)
        {
            L = l;
            W = w;
            H = h;
        }

        public double L
        {
            get { return this.l; }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Length cannot be zero or negative.");
                }
                this.l = value;
            }
        }
        public double W
        {
            get { return this.w; }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Width cannot be zero or negative.");
                }
                this.w = value;
            }
        }
        public double H
        {
            get { return this.h; }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Height cannot be zero or negative.");
                }
                this.h = value;
            }
        }

        public double SurfaceArea()
        {
            return 2 * l * w + 2 * l * h + 2 * w * h;
        }
        public double LateralSurfaceArea()
        {
            return 2 * l * h + 2 * w * h;
        }
        public double Volume()
        {
            return l * w * h;
        }
    }      
}
