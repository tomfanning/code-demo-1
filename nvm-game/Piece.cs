using System;

namespace nvm_game
{
    public class Piece
    {
        public byte BoardSize { get; private set; }
        public Direction Facing { get; set; }
        public byte XPosition { get; set; }
        public byte YPosition { get; set; }

        public Piece(byte boardSize, byte xpos, byte ypos, Direction direction)
        {
            BoardSize = boardSize;
            XPosition = xpos;
            YPosition = ypos;
            Facing = direction;
        }

        public void TurnRight()
        {
            Facing++;
        }

        public void TurnLeft()
        {
            Facing--;
        }

        public void Advance()
        {
            if (Facing == Direction.North)
            {
                YPosition = (byte)Math.Clamp(YPosition + 1, 0, BoardSize - 1);
            }
            else if (Facing == Direction.East)
            {
                XPosition = (byte)Math.Clamp(XPosition + 1, 0, BoardSize - 1);
            }
            else if (Facing == Direction.South)
            {
                YPosition = (byte)Math.Clamp(YPosition - 1, 0, BoardSize - 1);
            }
            else if (Facing == Direction.West)
            {
                XPosition = (byte)Math.Clamp(XPosition - 1, 0, BoardSize - 1);
            }
        }
    }
}