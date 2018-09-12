using System;
using System.Collections.Generic;

namespace nvm_game
{
    public class Game
    {
        private readonly Dictionary<Move, Action> moveMethods;
        private readonly IInputInterpreter inputInterpreter;
        private readonly IOutputGenerator outputGenerator;
        private readonly Piece piece;
        private const int BOARD_SIZE = 5;

        public Game(IInputInterpreter inputInterpreter, IOutputGenerator outputGenerator)
        {
            this.inputInterpreter = inputInterpreter;
            this.outputGenerator = outputGenerator;

            piece = new Piece(BOARD_SIZE, 0, 0, Direction.North);

            moveMethods = new Dictionary<Move, Action>
            {
                { Move.Advance, piece.Advance },
                { Move.TurnLeft, piece.TurnLeft },
                { Move.TurnRight, piece.TurnRight }
            };
        }

        public string Run(string input)
        {
            IEnumerable<Move> moves = inputInterpreter.Interpret(input);

            foreach (Move move in moves)
            {
                moveMethods[move].Invoke();
            }

            return outputGenerator.GenerateOutput(piece);
        }
    }
}