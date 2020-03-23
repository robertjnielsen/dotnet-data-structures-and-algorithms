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
    }
}
