using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Startup
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Family family = new Family();
        for (int i = 0; i < n; i++)
        {
            string[] personInfo = Console.ReadLine().Split();
            Person person = new Person();
            person.name = personInfo[0];
            person.age = int.Parse(personInfo[1]);
            family.AddMember(person);
        }
        family.AgeMoreThen30();
    }
}