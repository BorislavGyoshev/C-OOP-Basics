namespace P05_MordorSCrueltyPlan
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int points = 0;
            string input = Console.ReadLine();
            FoodFactory foodFactory = new FoodFactory(input);
            points = foodFactory.CalculatePoints();
            MoodFactory moodFactory = new MoodFactory(points);
            Console.WriteLine(points);
            Console.WriteLine(moodFactory.CalculateMood());
        }
    }
}
