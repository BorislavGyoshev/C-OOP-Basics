using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string name;
    public int age;

    public Person()
    {
        name = "No name";
        age = 1;
    }
    public Person(int age)
    {
        name = "No name";
        this.age = age;
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
