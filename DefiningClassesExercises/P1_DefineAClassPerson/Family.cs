using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Family
{
    private List<Person> people = new List<Person>();

    public void AddMember(Person member)
    {
        people.Add(member);
    }
    public Person GetOldestMember()
    {
        return people.OrderByDescending(p => p.age).FirstOrDefault();
    }
    public void AgeMoreThen30()
    {
        var people30 = people
            .Where(p => p.age > 30)
            .OrderBy(p => p.name)
            .ToList();
        foreach (Person person in people30)
        {
            Console.WriteLine($"{person.name} {person.age}");
        };
    }
}
