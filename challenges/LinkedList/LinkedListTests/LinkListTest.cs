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
    }
}
