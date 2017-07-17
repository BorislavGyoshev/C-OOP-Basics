namespace P05_MordorSCrueltyPlan
{
    using System;
    using System.Linq;

    public class FoodFactory
    {
        private int points;
        private string[] foods;

        public FoodFactory(string foods)
        {
            Foods = foods.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(f => f.ToLower()).ToArray();
            points = 0;
        }

        public string[] Foods
        {
            get { return this.foods; }
            set { this.foods = value; }
        }

        public int CalculatePoints()
        {
            foreach (var food in Foods)
            {
                switch (food)
                {
                    case "cram": points += 2; break;
                    case "lembas": points += 3; break;
                    case "apple": points += 1; break;
                    case "melon": points += 1; break;
                    case "honeycake": points += 5; break;
                    case "mushrooms": points -= 10; break;
                    default: points -= 1; break;
                }
            }
            return points;
        }
    }
}
