namespace TomF.NvmGame_tests
{
    using TomF.NvmGame;
    using Xunit;

    /// <summary>
    /// Implement tests to ensure the <see cref="OutputGenerator"/> works as specified
    /// </summary>
    public class OutputGeneratorTests
    {
        /// <summary>
        /// Ensure that position and direction is translated into the prescribed format
        /// </summary>
        /// <param name="xpos">The X position of the piece</param>
        /// <param name="ypos">The Y position of the piece</param>
        /// <param name="dir">The direction the piece is currently facing</param>
        /// <param name="expected">The position and direction in the prescribed format</param>
        [Theory]
        [InlineData(2, 2, Direction.East, "2 2 E")]
        [InlineData(3, 2, Direction.North, "3 2 N")]
        [InlineData(0, 4, Direction.North, "0 4 N")]
        public void Test_example_outputs(byte xpos, byte ypos, Direction dir, string expected)
        {
            IOutputGenerator outputGenerator = new OutputGenerator();

            string actual = outputGenerator.GenerateOutput(new Piece(byte.MaxValue, xpos, ypos, dir));

            Assert.Equal(expected, actual);
        }
    }
}