using System.Collections.Generic;

namespace nvm_game
{
    public class OutputGenerator : IOutputGenerator
    {
        private static readonly Dictionary<Direction, char> map = new Dictionary<Direction, char>
        {
            { Direction.North, 'N' },
            { Direction.East, 'E' },
            { Direction.South, 'S' },
            { Direction.West, 'W' }
        };

        public string GenerateOutput(Piece piece)
        {
            return $"{piece.XPosition} {piece.YPosition} {map[piece.Facing]}";
        }
    }
}
