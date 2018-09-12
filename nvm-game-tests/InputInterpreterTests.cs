using nvm_game;
using System.Collections.Generic;
using Xunit;

namespace nvm_game_tests
{
    public class InputInterpreterTests
    {
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