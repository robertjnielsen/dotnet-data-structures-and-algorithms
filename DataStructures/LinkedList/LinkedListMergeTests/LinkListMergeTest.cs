using System;
using Xunit;
using LinkedList.Classes;
using LinkedListMerge;

namespace LinkedListMergeTests
{
    public class LinkedListMergeTests
    {
        [Fact]
        public void CanInputTwoEqualLengthLinkedListsAndReturnAMergedList()
        {
            LinkList list1 = new LinkList();
            list1.Insert(1);
            list1.Append(3);
            list1.Append(5);

            LinkList list2 = new LinkList();
            list2.Insert(2);
            list2.Append(4);
            list2.Append(6);

            LinkList newList = Program.MergeLists(list1, list2);
            string expectedList = "1 -> 2 -> 3 -> 4 -> 5 -> 6 -> NULL";

            Assert.Equal(expectedList, newList.ToString());
        }

        [Fact]
        public void CanInputTwoVaryingLengthLinkedListsAndReturnAMergedList()
        {
            LinkList list1 = new LinkList();
            list1.Insert(1);
            list1.Append(3);
            list1.Append(5);

            LinkList list2 = new LinkList();
            list2.Insert(2);

            LinkList newList = Program.MergeLists(list1, list2);
            string expectedList = "1 -> 2 -> 3 -> 5 -> NULL";

            Assert.Equal(expectedList, newList.ToString());
        }
    }
}
