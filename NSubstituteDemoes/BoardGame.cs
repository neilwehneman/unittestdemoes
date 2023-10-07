namespace NSubstituteDemoes
{
    public class BoardGame
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public string Weight { get; set; }

        public BoardGame(string name, string genre, string weight)
        {
            Name = name;
            Genre = genre;
            Weight = weight;
        }
    }
}