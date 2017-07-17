namespace P03_Mankind
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        static void Main()
        {
            try
            {
                string[] studentInfo = Console.ReadLine().Split();
                Student student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                string[] workerInfo = Console.ReadLine().Split();
                Worker worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), decimal.Parse(workerInfo[3]));
                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
