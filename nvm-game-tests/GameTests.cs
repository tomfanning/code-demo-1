namespace TomF.NvmGame_tests
{
    using TomF.NvmGame;
    using Xunit;

    /// <summary>
    /// Tests for <see cref="Game"/>
    /// </summary>
    public class GameTests
    {
        /// <summary>
        /// Test the game scenarios work as expected, using the prescribed input and output formats
        /// </summary>
        /// <param name="input">The game input</param>
        /// <param name="expected">The expected result of running the game</param>
        [Theory]
        [InlineData("MRMLMRM", "2 2 E")]
        [InlineData("RMMMLMM", "3 2 N")]
        [InlineData("MMMMM", "0 4 N")]
        [InlineData("RMMMMM", "4 0 E")]
        public void Test_game_scenarios(string input, string expected)
        {
            var game = new Game(new InputInterpreter(), new OutputGenerator());

            string boardOutput = game.Run(input);

            Assert.Equal(expected, boardOutput);
        }
    }
}
