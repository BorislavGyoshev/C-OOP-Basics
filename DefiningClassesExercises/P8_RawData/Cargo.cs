using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_RawData
{
    public class Cargo
    {
        private int weight;
        private string type;

        public Cargo(int weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }

        public string Type
        {
            get { return this.type; }
        }
    }
}
