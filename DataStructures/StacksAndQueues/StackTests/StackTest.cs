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

        [Fact]
        public void CanSuccessfullyPushOnToAStack()
        {
            Stack testStack = new Stack();
            testStack.Push(3);

            int expected = 3;

            Assert.Equal(expected, testStack.Top.Value);
        }
    }
}
