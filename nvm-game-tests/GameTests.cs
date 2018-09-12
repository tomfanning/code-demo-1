using nvm_game;
using Xunit;

namespace nvm_game_tests
{
    public class GameTests
    {
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
