using System;
using Xunit;
using FindMaxBinaryTree.Classes;

namespace FindMaxBinaryTreeTests
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
