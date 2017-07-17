using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        private Queue<Product> products;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            products = new Queue<Product>();
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
        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                money = value;
            }
        }
        public void AddProduct(Product product)
        {
            products.Enqueue(product);
        }
        public void PrintProducts()
        {
            Console.Write($"{name} - ");
            if (products.Count == 0)
            {
                Console.WriteLine("Nothing bought");
            }
            else
            {
                Console.WriteLine(String.Join(", ", products.Select(p => p.Name)));
            }
        }
        public void SubstractMoney(decimal amount)
        {
            this.Money -= amount;
        }
    }
}
