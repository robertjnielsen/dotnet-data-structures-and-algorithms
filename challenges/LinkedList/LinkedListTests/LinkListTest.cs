using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedListTests
{
    public class LinkListTest
    {
        [Fact]
        public void EmptyLinkedListCanBeInstantiated()
        {
            LinkList ll = new LinkList();

            Assert.Null(ll.Head);
        }

        [Theory]
        [InlineData(42)]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(27)]
        public void CanInsertANewNodeIntoALinkedList(int value)
        {
            LinkList ll = new LinkList();

            ll.Insert(value);

            Assert.Equal(value, ll.Head.Value);
        }

        [Fact]
        public void CanProperlyInsertMultipleNodesIntoALinkedList()
        {
            LinkList ll = new LinkList();
            int listLength = 0;

            ll.Insert(42);
            ll.Insert(3);
            ll.Insert(9);
            ll.Insert(27);

            Node current = ll.Head;
            while (current != null)
            {
                listLength++;
                current = current.Next;
            }

            Assert.Equal(4, listLength);

        }

        [Fact]
        public void HeadPointsToFirstNodeInLinkedList()
        {
            LinkList ll = new LinkList();

            ll.Insert(42);
            ll.Insert(3);
            ll.Insert(9);
            ll.Insert(27);

            Node head = ll.Head;

            Assert.Equal(27, head.Value);
        }

        [Fact]
        public void CanSuccessfullyFindAnExistingValueWithinALinkedList()
        {
            LinkList ll = new LinkList();
            ll.Insert(42);
            ll.Insert(3);
            ll.Insert(9);
            ll.Insert(27);

            bool valueFound = ll.Includes(3);

            Assert.True(valueFound);
        }

        [Fact]
        public void CanSuccessfullyDetermineThatAValueDoesNotExistWithinALinkedList()
        {
            LinkList ll = new LinkList();
            ll.Insert(42);
            ll.Insert(3);
            ll.Insert(9);
            ll.Insert(27);

            bool valueFound = ll.Includes(19);

            Assert.False(valueFound);
        }

        [Fact]
        public void CanReturnAStringCollectionOfAllExistingValuesWithinALinkedList()
        {
            LinkList ll = new LinkList();
            ll.Insert(42);
            ll.Insert(3);
            ll.Insert(9);
            ll.Insert(27);

            string expectedString = "27 -> 9 -> 3 -> 42 -> NULL";
            string listString = ll.ToString();

            Assert.Equal(expectedString, listString);
        }

        [Fact]
        public void CanSuccessfullyAddANodeToTheEndOfTheLinkedList()
        {
            LinkList ll = new LinkList();
            ll.Insert(5);
            ll.Insert(9);
            ll.Append(19);

            Node current = ll.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            int lastNodeValue = current.Value;

            Assert.Equal(19, lastNodeValue);
        }

        [Fact]
        public void CanAddMultipleNodesToTheEndOfALinkedList()
        {
            LinkList ll = new LinkList();
            ll.Insert(5);
            ll.Insert(9);
            ll.Append(19);
            ll.Append(27);
            ll.Append(42);

            Node current = ll.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            int lastNodeValue = current.Value;

            Assert.Equal(42, lastNodeValue);
        }

        [Fact]
        public void CanAddANodeBeforeAnotherNodeInTheMiddleOfTheLinkedList()
        {
            LinkList ll = new LinkList();
            ll.Insert(3);
            ll.Append(9);
            ll.Append(27);
            ll.Append(42);

            ll.InsertBefore(27, 19);
            Node current = ll.Head;
            while (current.Next.Value != 27)
            {
                current = current.Next;
            }

            Assert.Equal(19, current.Value);
        }

        [Fact]
        public void CanSuccessfullyInsertANewNodeAfterANodeInALinkedList()
        {
            LinkList ll = new LinkList();
            ll.Insert(3);
            ll.Append(9);
            ll.Append(27);
            ll.Append(42);

            ll.InsertAfter(9, 19);
            Node current = ll.Head;
            while (current.Value != 19)
            {
                current = current.Next;
            }

            Assert.Equal(19, current.Value);
        }
    }
}
