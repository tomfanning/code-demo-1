namespace TomF.NvmGame
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines what an input interpreter should be able to do
    /// </summary>
    public interface IInputInterpreter
    {
        /// <summary>
        /// Interpret a string containing game input in some non-specific format
        /// </summary>
        /// <param name="input">The game input, represented by a string format</param>
        /// <returns>A collection of valid moves</returns>
        IEnumerable<Move> Interpret(string input);
    }
}