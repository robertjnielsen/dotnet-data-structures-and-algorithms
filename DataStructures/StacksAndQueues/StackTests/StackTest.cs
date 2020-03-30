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

        [Fact]
        public void CanSuccessfullyPushMultipleValuesToAStack()
        {
            Stack testStack = new Stack();
            testStack.Push(3);
            testStack.Push(9);
            testStack.Push(19);

            int expected = 19;

            Assert.Equal(expected, testStack.Top.Value);
        }
    }
}
