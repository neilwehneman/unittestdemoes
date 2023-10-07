namespace NSubstituteDemoes
{
    public class GameQuery
    {
        private IGamePicker _gamePicker;

        public GameQuery(IGamePicker gamePicker)
        {
            _gamePicker = gamePicker;
        }

        public BoardGame? SelectGameBasedOnParameters(string genreParameter, string weightParameter)
        {
            List<BoardGame>? gameLibrary = _gamePicker.NarrowToGenre(genreParameter);

            return _gamePicker.PickActualGame(gameLibrary, weightParameter);
        }
    }
}