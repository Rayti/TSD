namespace WebApplication1.Models
{
    public class Recipe
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public int Difficulty { get; set; }
        public int NumberOfLikes { get; set; }
        public string Ingredients { get; set; }
        public string Process { get; set; }
        public string TipsAndTricks { get; set; }

        public Recipe() { }

        public Recipe(int id, string name, int time, int difficulty, int numberOfLikes, string ingredients, string process,  string tipsandtricks)
        {
            Id = id;
            Name = name;
            Time = time;
            Difficulty = difficulty;
            NumberOfLikes = numberOfLikes;
            Ingredients = ingredients;
            Process = process;
            TipsAndTricks = tipsandtricks;
        }
    }
}
