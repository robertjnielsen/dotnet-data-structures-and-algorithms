using System;
using Xunit;
using MergeSort;

namespace MergeSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSuccessfullySortGivenArray()
        {
            int[] arr = new int[] { 8, 4, 23, 42, 16, 15 };

            int[] expected = new int[] { 4, 8, 15, 16, 23, 42 };

            Program.MergeSort(arr);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void CanSortTwoElementArray()
        {
            int[] arr = new int[] { 9, 3 };

            int[] expected = new int[] { 3, 9 };

            Program.MergeSort(arr);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void CanSortReverseSortedArray()
        {
            int[] arr = new int[] { 20, 18, 12, 8, 5, -2 };

            int[] expected = { -2, 5, 8, 12, 18, 20 };

            Program.MergeSort(arr);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void CanSortArrayWithDuplicateValues()
        {
            int[] arr = { 5, 12, 7, 5, 5, 7 };

            int[] expected = { 5, 5, 5, 7, 7, 12 };

            Program.MergeSort(arr);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void CanSortNearlySortedArray()
        {
            int[] arr = { 2, 3, 5, 7, 13, 11 };

            int[] expected = { 2, 3, 5, 7, 11, 13 };

            Program.MergeSort(arr);

            Assert.Equal(expected, arr);
        }
    }
}
