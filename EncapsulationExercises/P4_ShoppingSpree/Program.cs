using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peopleAndMoney = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] productsAndCost = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            foreach (var p in peopleAndMoney)
            {
                string[] str = p.Split('=');
                try
                {
                    Person person = new Person(str[0], decimal.Parse(str[1]));
                    people.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            foreach (var p in productsAndCost)
            {
                string[] str = p.Split('=');
                try
                {
                    Product product = new Product(str[0], decimal.Parse(str[1]));
                    products.Add(product);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] str = input.Split();
                Person currentPerson = people.FirstOrDefault(p => p.Name == str[0]);
                Product currentProduct = products.FirstOrDefault(p => p.Name == str[1]);
                if (currentPerson.Money >= currentProduct.Cost)
                {
                    currentPerson.AddProduct(currentProduct);
                    currentPerson.SubstractMoney(currentProduct.Cost);
                    Console.WriteLine($"{ currentPerson.Name} bought {currentProduct.Name}");
                }
                else
                {
                    Console.WriteLine($"{ currentPerson.Name} can't afford {currentProduct.Name}");
                }
            }
            foreach (var p in people)
            {
                p.PrintProducts();
            }
        }
    }
}
