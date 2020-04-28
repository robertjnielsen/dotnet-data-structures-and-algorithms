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
    }
}
