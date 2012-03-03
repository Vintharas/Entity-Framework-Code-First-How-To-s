namespace SamuraiWars.Model
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public Castle InCastle { get; set; }
    }
}