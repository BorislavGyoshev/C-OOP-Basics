using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_ShoppingSpree
{
    class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Cost
        {
            get { return this.cost; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Cost cannot be negative");
                }
                cost = value;
            }
        }
    }
}
