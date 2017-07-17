namespace P06_Animals
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string animal;
            int age = 0;
            while ((animal = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    string[] animalData = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                    if (!int.TryParse(animalData[1], out age))
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                    switch (animal.ToLower())
                    {
                        case "cat": Cat cat = new Cat(animalData[0], int.Parse(animalData[1]), animalData[2]);
                            Console.WriteLine("Cat");
                            Console.WriteLine($"{cat.Name} {cat.Age} {cat.Gender}");
                            Console.WriteLine(cat.ProduceSound()); break;
                        case "dog": Dog dog = new Dog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                            Console.WriteLine("Dog");
                            Console.WriteLine($"{dog.Name} {dog.Age} {dog.Gender}");
                            Console.WriteLine(dog.ProduceSound()); break;
                        case "frog":
                            Frog frog = new Frog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                            Console.WriteLine("Frog");
                            Console.WriteLine($"{frog.Name} {frog.Age} {frog.Gender}");
                            Console.WriteLine(frog.ProduceSound()); break;
                        case "kitten":
                            Kitten kitten = new Kitten(animalData[0], int.Parse(animalData[1]));
                            Console.WriteLine("Kitten");
                            Console.WriteLine($"{kitten.Name} {kitten.Age} {kitten.Gender}");
                            Console.WriteLine(kitten.ProduceSound()); break;
                        case "tomcat":
                            Tomcat tomcat = new Tomcat(animalData[0], int.Parse(animalData[1]));
                            Console.WriteLine("Tomcat");
                            Console.WriteLine($"{tomcat.Name} {tomcat.Age} {tomcat.Gender}");
                            Console.WriteLine(tomcat.ProduceSound()); break;
                        default:
                            throw new ArgumentException("Invalid input!");
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
