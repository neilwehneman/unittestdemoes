namespace NSubstituteDemoes
{
    public class Program
    {
        public static List<BoardGame>? gameLibrary = SeedTheData();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game selector!");

            Console.WriteLine("Press A to select a strategic game, press B to select a thematic game");

            string input1 = Console.ReadLine()!.ToUpper();

            Console.WriteLine("Press 1 to select a lighter game within that genre, press 2 to select a heavier game within that genre");

            string input2 = Console.ReadLine()!;

            GameQuery gameQuery = new GameQuery(new GamePicker());

            BoardGame? gameToPlay = gameQuery.SelectGameBasedOnParameters(input1, input2);

            if (gameToPlay == null)
            {
                Console.WriteLine("Invalid input");
            }

            else
            {
                Console.WriteLine($"You should play {gameToPlay.Name}!");
            }

            Console.ReadKey();
        }

        private static List<BoardGame> SeedTheData()
        {
            BoardGame endeavor = new BoardGame("Endeavor: Age of Sail", "Strategic", "lighter");
            BoardGame terraformingMars = new BoardGame("Terraforming Mars", "Strategic", "heavier");
            BoardGame warOfTheRing = new BoardGame("War of the Ring", "Thematic", "lighter");
            BoardGame twilightImperium = new BoardGame("Twilight Imperium: Fourth Edition", "Thematic", "heavier");

            List<BoardGame> gamingLibrary = new List<BoardGame>
            {
                endeavor,
                terraformingMars,
                warOfTheRing,
                twilightImperium
            };

            return gamingLibrary;
        }
    }
}