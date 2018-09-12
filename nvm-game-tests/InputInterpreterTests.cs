namespace TomF.NvmGame_tests
{
    using System.Collections.Generic;
    using TomF.NvmGame;
    using Xunit;

    /// <summary>
    /// Implements tests for the implementation of <see cref="InputInterpreter"/>
    /// </summary>
    public class InputInterpreterTests
    {
        /// <summary>
        /// Test whether input in the specified format is interpreted correctly
        /// </summary>
        /// <param name="inputStr">Input in the specified format</param>
        /// <param name="expected">A collection of moves represented by the input</param>
        [Theory]
        [InlineData("MRMLMRM", new[] { Move.Advance, Move.TurnRight, Move.Advance, Move.TurnLeft, Move.Advance, Move.TurnRight, Move.Advance })]
        [InlineData("RMMMLMM", new[] { Move.TurnRight, Move.Advance, Move.Advance, Move.Advance, Move.TurnLeft, Move.Advance, Move.Advance })]
        [InlineData("MMMMM", new[] { Move.Advance, Move.Advance, Move.Advance, Move.Advance, Move.Advance })]
        public void Test_example_inputs(string inputStr, IEnumerable<Move> expected)
        {
            IInputInterpreter inputInterpreter = new InputInterpreter();

            var actual = inputInterpreter.Interpret(inputStr);

            Assert.Equal(expected, actual);
        }
    }
}