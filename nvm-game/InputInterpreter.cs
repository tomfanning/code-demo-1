namespace TomF.NvmGame
{
    using System.Collections.Generic;

    /// <summary>
    /// Implements an <see cref="IInputInterpreter"/> which functions as per the prescribed specification
    /// </summary>
    public class InputInterpreter : IInputInterpreter
    {
        private static readonly Dictionary<char, Move> MoveMap = new Dictionary<char, Move>
        {
            { 'M', Move.Advance },
            { 'L', Move.TurnLeft },
            { 'R', Move.TurnRight }
        };

        /// <summary>
        /// Interpret a string containing game input in the prescribed format
        /// </summary>
        /// <param name="input">Text in the prescribed format, e.g. MLLMRM</param>
        /// <returns>A collection of valid moves representing the input</returns>
        public IEnumerable<Move> Interpret(string input)
        {
            foreach (char c in input)
            {
                if (MoveMap.TryGetValue(c, out Move move))
                {
                    yield return move;
                }
            }
        }
    }
}
