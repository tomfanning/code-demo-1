using nvm_game;
using Xunit;

namespace nvm_game_tests
{
    public class OutputGeneratorTests
    {
        [Theory]
        [InlineData(2, 2, Direction.East, "2 2 E")]
        [InlineData(3, 2, Direction.North, "3 2 N")]
        [InlineData(0, 4, Direction.North, "0 4 N")]
        public void Test_example_outputs(byte xpos, byte ypos, Direction dir, string expected)
        {
            IOutputGenerator outputGenerator = new OutputGenerator();

            string actual = outputGenerator.GenerateOutput(new Piece(byte.MaxValue, xpos, ypos, dir ));

            Assert.Equal(expected, actual);
        }
    }
}