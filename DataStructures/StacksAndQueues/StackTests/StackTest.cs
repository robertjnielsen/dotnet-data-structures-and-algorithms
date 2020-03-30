using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StackTests
{
    public class StackTest
    {
        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyStack()
        {
            Stack testStack = new Stack();

            Node expected = testStack.Top;

            Assert.Null(expected);
        }
    }
}
