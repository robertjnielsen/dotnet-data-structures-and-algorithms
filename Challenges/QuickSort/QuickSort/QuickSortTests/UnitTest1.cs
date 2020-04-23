using System;
using Xunit;
using QuickSort;

namespace QuickSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortAnArray()
        {
            int[] arr = { 8, 4, 23, 42, 16, 15 };
            int[] expected = { 4, 8, 15, 16, 23, 42 };

            Program.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void CanSortReverseSortedArray()
        {
            int[] arr = { 20, 18, 12, 8, 5, -2 };
            int[] expected = { -2, 5, 8, 12, 18, 20 };

            Program.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void CanSortArrayWithFewUniqueElement()
        {
            int[] arr = { 5, 12, 7, 5, 5, 7 };
            int[] expected = { 5, 5, 5, 7, 7, 12 };

            Program.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void CanSortANearlySortedArray()
        {
            int[] arr = { 2, 3, 5, 7, 13, 11 };
            int[] expected = { 2, 3, 5, 7, 11, 13 };

            Program.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(expected, arr);
        }
    }
}
