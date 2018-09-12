namespace TomF.NvmGame
{
    using System.Collections.Generic;

    /// <summary>
    /// Functionality to describe the state (position and direction) of the piece in the prescribed format
    /// </summary>
    public class OutputGenerator : IOutputGenerator
    {
        private static readonly Dictionary<Direction, char> Map = new Dictionary<Direction, char>
        {
            { Direction.North, 'N' },
            { Direction.East, 'E' },
            { Direction.South, 'S' },
            { Direction.West, 'W' }
        };

        /// <summary>
        /// Transform the current position and facing direction of the piece into a string in the prescribed format
        /// </summary>
        /// <param name="piece">The piece to describe the position and direction of</param>
        /// <returns>A string repsenting the current position and direction the piece is facing, in the prescribed format</returns>
        public string GenerateOutput(Piece piece)
        {
            return $"{piece.XPosition} {piece.YPosition} {Map[piece.Facing]}";
        }
    }
}
