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

        [Fact]
        public void CanSuccessfullyPopOffAStack()
        {
            Stack testStack = new Stack();
            testStack.Push(3);
            testStack.Push(9);
            testStack.Push(19);

            int expected = 9;
            testStack.Pop();

            Assert.Equal(expected, testStack.Top.Value);
        }

        [Fact]
        public void CanSuccessfullyEmptyAStackAfterMultiplePops()
        {
            Stack testStack = new Stack();
            testStack.Push(3);
            testStack.Push(9);
            testStack.Push(19);

            testStack.Pop();
            testStack.Pop();
            testStack.Pop();

            Assert.Null(testStack.Top);
        }

        [Fact]
        public void CanSuccessfullyPeekTheNextItemOnTheStack()
        {
            Stack testStack = new Stack();
            testStack.Push(3);
            testStack.Push(9);
            testStack.Push(19);

            int expected = 19;

            Assert.Equal(expected, testStack.Peek());
        }

        [Fact]
        public void CallingPopOnEmptyStackRaisesException()
        {
            Stack testStack = new Stack();

            Assert.ThrowsAny<Exception>(() => testStack.Pop());
        }
    }
}
