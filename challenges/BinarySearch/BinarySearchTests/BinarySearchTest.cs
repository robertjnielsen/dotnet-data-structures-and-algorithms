using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTests
{
    public class ProgramTests
    {
        [Fact]
        public void BinarySearchReturnsCorrectIndex()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7 };
            int testKey = 3;

            int returnedIndex = Program.BinarySearch(testArray, testKey);

            Assert.Equal(2, returnedIndex);
        }

        [Fact]
        public void BinarySearchReturnsNegativeOneIfElementDoesNotExist()
        {
            int[] testArray = { 1, 3, 5, 7, 9, 11, 13 };
            int testKey = 4;

            int returnedIndex = Program.BinarySearch(testArray, testKey);

            Assert.Equal(-1, returnedIndex);
        }
    }
}
