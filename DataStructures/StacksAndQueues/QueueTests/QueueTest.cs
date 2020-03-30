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
    }
}
