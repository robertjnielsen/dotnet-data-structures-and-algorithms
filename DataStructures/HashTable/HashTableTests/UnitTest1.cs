using System;
using Xunit;
using HashTables;
using HashTables.Classes;

namespace HashTableTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSuccessfullyHashAKeyToAnInRangeValue()
        {
            HashTable table = new HashTable(1024);

            int value = table.Hash("test");

            Assert.True(value < table.Size);
        }

        [Fact]
        public void HandleACollisionWithinAHashTable()
        {
            HashTable table = new HashTable(1024);

            table.Add("abc", "Some text.");
            table.Add("cba", "Some other text.");

            int value1 = table.Hash("abc");
            int value2 = table.Hash("cba");

            Assert.Equal(value1, value2);
        }

        [Fact]
        public void CanRetrieveAValueFromABucketWithCollisions()
        {
            HashTable table = new HashTable(1024);

            table.Add("abc", "Some text.");
            table.Add("cba", "Some other text.");

            string result1 = table.Get("abc");
            string result2 = table.Get("cba");

            string expected1 = "Some text.";
            string expected2 = "Some other text.";

            Assert.Equal(expected1, result1);
            Assert.Equal(expected2, result2);
        }

        [Fact]
        public void CanDetermineIfAKeyExistsInAHashTable()
        {
            HashTable table = new HashTable(1024);

            bool exists = table.Contains("abc");

            Assert.Equal(false, exists);
        }

        [Fact]
        public void CanRetrieveValueBasedOnKey()
        {
            HashTable table = new HashTable(1024);

            table.Add("abc", "Some text.");

            string result = table.Get("abc");

            string expected = "Some text.";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanAddKeyValuePairToHashTable()
        {
            HashTable table = new HashTable(1024);

            table.Add("abc", "Some text.");

            bool result = table.Contains("abc");

            Assert.True(result);
        }
    }
}
