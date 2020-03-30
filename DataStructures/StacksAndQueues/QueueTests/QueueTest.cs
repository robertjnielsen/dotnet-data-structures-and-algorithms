using System;
using Xunit;
using StacksAndQueues.Classes;

namespace QueueTests
{
    public class QueueTest
    {
        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyQueue()
        {
            Queue testQueue = new Queue();

            Node expected = testQueue.Front;

            Assert.Null(expected);
        }

        [Fact]
        public void CallingDequeueOnAnEmptyQueueRaisesAnException()
        {
            Queue testQueue = new Queue();

            Assert.ThrowsAny<Exception>(() => testQueue.Dequeue());
        }

        [Fact]
        public void CallingPeekOnAnEmptyQueueRaisesAnException()
        {
            Queue testQueue = new Queue();

            Assert.ThrowsAny<Exception>(() => testQueue.Peek());
        }

        [Fact]
        public void CanSuccessfullyEnqueueToAQueue()
        {
            Queue testQueue = new Queue();

            testQueue.Enqueue(3);

            int expected = 3;

            Assert.Equal(expected, testQueue.Front.Value);
        }
    }
}
