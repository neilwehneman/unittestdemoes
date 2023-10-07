namespace NSubstituteDemoes
{
    public class GamePicker : IGamePicker
    {
        public List<BoardGame>? NarrowToGenre(string input)
        {
            /*
            string genre = ConvertInputToGenre(input);

            List<BoardGame>? list = Program.gameLibrary?.Where(game => game.Genre == genre).ToList();

            if (list != null && list.Count == 0)
            {
                return null;
            }

            return list;
            */

            throw new NotImplementedException();
        }

        public BoardGame? PickActualGame(List<BoardGame>? library, string input)
        {
            /*
            string weight = ConvertInputToWeight(input);

            return library?.Where(game => game.Weight == weight).SingleOrDefault();
            */

            throw new NotImplementedException();
        }

        public string ConvertInputToGenre(string input)
        {
            if (input == "A")
            {
                return "Strategic";
            }

            else if (input == "B")
            {
                return "Thematic";
            }

            else
            {
                return "";
            }
        }

        public string ConvertInputToWeight(string input)
        {
            if (input == "1")
            {
                return "lighter";
            }

            else if (input == "2")
            {
                return "heavier";
            }

            else
            {
                return "";
            }
        }
    }
}