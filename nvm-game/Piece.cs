namespace TomF.NvmGame
{
    using System;

    /// <summary>
    /// Describes where a piece is on a board, and provides operations to manipulate the piece
    /// </summary>
    public class Piece
    {
        private byte boardSize;

        /// <summary>
        /// Initializes a new instance of the <see cref="Piece"/> class.
        /// </summary>
        /// <param name="boardSize">The size of the board edge, e.g. 5 for a 5x5 square board.</param>
        /// <param name="startingXpos">Where the piece should start in the X axis</param>
        /// <param name="startingYpos">Where the piece should start in the Y axis</param>
        /// <param name="startingDirection">Which direction the piece should be facing to start</param>
        public Piece(byte boardSize, byte startingXpos, byte startingYpos, Direction startingDirection)
        {
            this.boardSize = boardSize;
            XPosition = startingXpos;
            YPosition = startingYpos;
            Facing = startingDirection;
        }

        /// <summary>
        /// Gets or sets which direction the piece is currently facing.
        /// </summary>
        public Direction Facing { get; set; }

        /// <summary>
        /// Gets or sets the X position (left-right) of the piece, with 0 representing the left.
        /// </summary>
        public byte XPosition { get; set; }

        /// <summary>
        /// Gets or sets the Y position (up-down) of the piece, with 0 representing the bottom.
        /// </summary>
        public byte YPosition { get; set; }

        /// <summary>
        /// Turn the piece right/clockwise 90 degrees.
        /// </summary>
        public void TurnRight()
        {
            if (Facing == Direction.West)
            {
                Facing = Direction.North;
            }
            else
            {
                Facing++;
            }
        }

        /// <summary>
        /// Turn the piece left/anti-clockwise 90 degrees
        /// </summary>
        public void TurnLeft()
        {
            if (Facing == Direction.North)
            {
                Facing = Direction.West;
            }
            else
            {
                Facing--;
            }
        }

        /// <summary>
        /// Move one square in the direction the piece is currently facing. If we try to move off the board edge, do nothing.
        /// </summary>
        public void Advance()
        {
            if (Facing == Direction.North)
            {
                YPosition = (byte)Math.Clamp(YPosition + 1, 0, boardSize - 1);
            }
            else if (Facing == Direction.East)
            {
                XPosition = (byte)Math.Clamp(XPosition + 1, 0, boardSize - 1);
            }
            else if (Facing == Direction.South)
            {
                YPosition = (byte)Math.Clamp(YPosition - 1, 0, boardSize - 1);
            }
            else if (Facing == Direction.West)
            {
                XPosition = (byte)Math.Clamp(XPosition - 1, 0, boardSize - 1);
            }
        }
    }
}