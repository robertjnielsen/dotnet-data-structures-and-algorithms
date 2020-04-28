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
    }
}
