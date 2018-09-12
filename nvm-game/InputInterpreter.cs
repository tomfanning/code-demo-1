using System.Collections.Generic;

namespace nvm_game
{
    public class InputInterpreter : IInputInterpreter
    {
        private static readonly Dictionary<char, Move> moveMap = new Dictionary<char, Move>
        {
            { 'M', Move.Advance },
            { 'L', Move.TurnLeft },
            { 'R', Move.TurnRight }
        };

        public IEnumerable<Move> Interpret(string input)
        {
            foreach (char c in input)
            {
                if (moveMap.TryGetValue(c, out Move move))
                {
                    yield return move;
                }
            }
        }
    }
}
