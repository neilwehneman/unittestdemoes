namespace NSubstituteDemoes
{
    public interface IGamePicker
    {
        public List<BoardGame>? NarrowToGenre(string input);

        public BoardGame? PickActualGame(List<BoardGame>? library, string input);
    }
}