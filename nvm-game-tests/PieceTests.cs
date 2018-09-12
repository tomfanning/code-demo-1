namespace TomF.NvmGame_tests
{
    using TomF.NvmGame;
    using Xunit;

    /// <summary>
    /// Tests for <see cref="Piece"/>
    /// </summary>
    public class PieceTests
    {
        /// <summary>
        /// Ensure that when TurnRight() is called when at west, that the piece wraps around to the north.
        /// </summary>
        [Fact]
        public void Test_that_rotate_wraps_clockwise()
        {
            var piece = new Piece(5, 0, 0, Direction.North);
            Assert.Equal(Direction.North, piece.Facing);
            piece.TurnRight();
            Assert.Equal(Direction.East, piece.Facing);
            piece.TurnRight();
            Assert.Equal(Direction.South, piece.Facing);
            piece.TurnRight();
            Assert.Equal(Direction.West, piece.Facing);
            piece.TurnRight();
            Assert.Equal(Direction.North, piece.Facing);
        }

        /// <summary>
        /// Ensure that when TurnLeft() is called when at north, that the piece wraps around to the west.
        /// </summary>
        [Fact]
        public void Test_that_rotate_wraps_anticlockwise()
        {
            var piece = new Piece(5, 0, 0, Direction.North);
            Assert.Equal(Direction.North, piece.Facing);
            piece.TurnLeft();
            Assert.Equal(Direction.West, piece.Facing);
            piece.TurnLeft();
            Assert.Equal(Direction.South, piece.Facing);
            piece.TurnLeft();
            Assert.Equal(Direction.East, piece.Facing);
            piece.TurnLeft();
            Assert.Equal(Direction.North, piece.Facing);
        }

        /// <summary>
        /// Test that the piece can be initialised correctly when not in the standard (0,0,N) configuration
        /// </summary>
        [Fact]
        public void Test_that_piece_initialises_nonstandard()
        {
            var piece = new Piece(5, 3, 2, Direction.West);

            Assert.Equal(Direction.West, piece.Facing);
            Assert.Equal(3, piece.XPosition);
            Assert.Equal(2, piece.YPosition);
        }
    }
}
