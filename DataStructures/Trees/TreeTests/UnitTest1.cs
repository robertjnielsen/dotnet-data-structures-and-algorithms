using System;
using Trees.Classes;
using Xunit;

namespace TreeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateAnEmptyTree()
        {
            BinaryTree tree = new BinaryTree();

            Assert.Null(tree.Root);
        }
    }
}
