using System;
using Xunit;
using MultiBracketValidation;
using MultiBracketValidation.Classes;

namespace BracketValidationTests
{
    public class BracketTest
    {
        [Fact]
        public void HelperMethodCanSuccessfullyValidateBrackets()
        {
            char open = '{';
            char close = '}';

            bool validated = Program.ValidateOnPop(open, close);

            Assert.True(validated);
        }

        [Fact]
        public void HelperMethodCanSuccessfullyFalseInvalidBrackets()
        {
            char open = '[';
            char close = ')';

            bool validated = Program.ValidateOnPop(open, close);

            Assert.False(validated);
        }
    }
}
