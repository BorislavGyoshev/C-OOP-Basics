namespace P05_MordorSCrueltyPlan
{
    public class MoodFactory
    {
        private string mood;

        public MoodFactory(int points)
        {
            Points = points;
        }

        public int Points { get; set; }

        public string CalculateMood()
        {
            if (Points < -5)
            {
                mood = "Angry";
            }
            else if (Points >= -5 && Points <= 0)
            {
                mood = "Sad";
            }
            else if (Points >= 1 && Points <= 15)
            {
                mood = "Happy";
            }
            else if (Points > 15)
            {
                mood = "JavaScript";
            }
            return mood;
        }
    }
}
