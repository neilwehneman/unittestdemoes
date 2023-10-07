using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace NSubstituteDemoes.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void LightStrategicGameSelection()
        {
            // Arrange
            string genreInput = "A";
            string weightInput = "1";
            string expectedGameName = "Endeavor: Age of Sail";

            IGamePicker gamePicker = Substitute.For<IGamePicker>();

            List<BoardGame>? narrowedLibrary = Program.gameLibrary?.Where(game => game.Genre == "Strategic").ToList();
            gamePicker.NarrowToGenre(genreInput).Returns(narrowedLibrary);
            gamePicker.PickActualGame(narrowedLibrary, weightInput)
                .Returns(narrowedLibrary?.Where(game => game.Weight == "lighter").SingleOrDefault());
  
            GameQuery systemUnderTest = new GameQuery(gamePicker);
        
            // Act
            BoardGame? actualGame = systemUnderTest.SelectGameBasedOnParameters(genreInput, weightInput);

            // Assert
            Assert.AreEqual(expectedGameName, actualGame?.Name);
        }

        [TestMethod]
        public void ConvertAToStrategic()
        {
            // Arrange
            string input = "A";
            string expectedGenre = "Strategic";

            GamePicker systemUnderTest = new GamePicker();

            // Act
            string actualGenre = systemUnderTest.ConvertInputToGenre(input);

            // Assert
            Assert.AreEqual(expectedGenre, actualGenre);
        }

        [TestMethod]
        public void ConvertBToThematic()
        {
            // Arrange
            string input = "B";
            string expectedGenre = "Thematic";

            GamePicker systemUnderTest = new GamePicker();

            // Act
            string actualGenre = systemUnderTest.ConvertInputToGenre(input);

            // Assert
            Assert.AreEqual(expectedGenre, actualGenre);
        }

        [TestMethod]
        public void ConvertCToEmptyString()
        {
            // Arrange
            string input = "C";
            string expectedGenre = "";

            GamePicker systemUnderTest = new GamePicker();

            // Act
            string actualGenre = systemUnderTest.ConvertInputToGenre(input);

            // Assert   
            Assert.AreEqual(expectedGenre, actualGenre);
        }

        [TestMethod]
        public void Convert1ToLighter()
        {
            // Arrange
            string input = "1";
            string expectedWeight = "lighter";

            GamePicker systemUnderTest = new GamePicker();

            // Act
            string actualWeight = systemUnderTest.ConvertInputToWeight(input);

            // Assert
            Assert.AreEqual(expectedWeight, actualWeight);
        }

        [TestMethod]
        public void Convert2ToHeavier()
        {
            // Arrange
            string input = "2";
            string expectedWeight = "heavier";

            GamePicker systemUnderTest = new GamePicker();

            // Act
            string actualWeight = systemUnderTest.ConvertInputToWeight(input);

            // Assert
            Assert.AreEqual(expectedWeight, actualWeight);  
        }

        [TestMethod]
        public void Convert3ToEmptyString()
        {
            // Arrange
            string input = "3";
            string expectedWeight = "";

            GamePicker systemUnderTest = new GamePicker();

            // Act
            string actualWeight = systemUnderTest.ConvertInputToWeight(input);

            // Assert   
            Assert.AreEqual(expectedWeight, actualWeight);
        }
    }
}