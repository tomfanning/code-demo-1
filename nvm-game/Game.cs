namespace TomF.NvmGame
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Implements the game "engine" itself
    /// </summary>
    public class Game
    {
        private const int BoardSize = 5;
        private readonly Dictionary<Move, Action> moveMethods;
        private readonly IInputInterpreter inputInterpreter;
        private readonly IOutputGenerator outputGenerator;
        private readonly Piece piece;

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        /// <param name="inputInterpreter">An <see cref="IInputInterpreter"/> implementation</param>
        /// <param name="outputGenerator">An <see cref="IOutputGenerator"/> implementation</param>
        public Game(IInputInterpreter inputInterpreter, IOutputGenerator outputGenerator)
        {
            this.inputInterpreter = inputInterpreter;
            this.outputGenerator = outputGenerator;

            piece = new Piece(BoardSize, 0, 0, Direction.North);

            moveMethods = new Dictionary<Move, Action>
            {
                { Move.Advance, piece.Advance },
                { Move.TurnLeft, piece.TurnLeft },
                { Move.TurnRight, piece.TurnRight }
            };
        }

        /// <summary>
        /// Performs a run of the game engine
        /// </summary>
        /// <param name="input">The input parameter for the game, e.g. &quot;RMMLM&quot;</param>
        /// <returns>The string output of the game run, e.g. &quot;0 4 N&quot;</returns>
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