using System.Collections.Generic;

namespace nvm_game
{
    public interface IInputInterpreter
    {
        IEnumerable<Move> Interpret(string input);
    }
}