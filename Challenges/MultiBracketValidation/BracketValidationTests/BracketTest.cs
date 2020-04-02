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

        [Fact]
        public void CanValidateMatchingBrackets()
        {
            string testString = "{}{Extra}[Characters](())";

            bool validated = Program.MultiBracketValidation(testString);

            Assert.True(validated);
        }

        [Fact]
        public void CanValidateFalseBracketPairs()
        {
            string testString = "{}{Extra]{Characters]({)}";

            bool validated = Program.MultiBracketValidation(testString);

            Assert.False(validated);
        }
    }
}
